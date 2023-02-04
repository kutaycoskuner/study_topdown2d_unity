using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// added
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    // ----- Variables --------------------------------------------------------
    public float moveSpeed = 1f;
    public float collisionOffset = 0.05f;
    public ContactFilter2D movementFilter;

    Vector2 movementInput;
    Rigidbody2D rb;
    List<RaycastHit2D> castCollisions = new List<RaycastHit2D>();

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        // if movement input is not 0, try to move
        // Debug.Log(movementInput.x, movementInput.y);
        if (movementInput != Vector2.zero)
        {
            bool canMove = TryMove(movementInput);
        if (!canMove)
        {
            canMove = TryMove(new Vector2(movementInput.x, 0));
        }
        if (!canMove)
        {
            canMove = TryMove(new Vector2(0, movementInput.y));
        }
        }
    }

    private bool TryMove(Vector2 direction)
    {
        // check potential collisions
        int collisionCount = rb.Cast(
            direction, //  x and y values between -1 1 that represents the direction from the body to look for collisiotns
            movementFilter, // the settings that determine where a collision can occur on such as layers to collide with
            castCollisions, // list of collisions to store the found collisions into after the cast is finished
            moveSpeed * Time.fixedDeltaTime + collisionOffset // the amount to cast equal to the movement plus an offset
        );
        if (collisionCount != 0)
        {
            return false;
        }
        rb.MovePosition(rb.position + direction * moveSpeed * Time.fixedDeltaTime);
        return true;
    }

    void OnMove(InputValue movementValue)
    {
        movementInput = movementValue.Get<Vector2>();
    }
}
