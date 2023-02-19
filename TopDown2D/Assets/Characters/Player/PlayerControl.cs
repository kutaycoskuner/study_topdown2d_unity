using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// added
using UnityEngine.InputSystem;

public class PlayerControl : MonoBehaviour
{
    // ------------------------------------------------------------------------
    // ----- Variables --------------------------------------------------------
    // ------------------------------------------------------------------------

    // ----- public -----------------------------------------------------------
    public float moveSpeed = 1f;
    public float collisionOffset = 0.05f;
    public ContactFilter2D movementFilter;
    // public BasicAttack basicAttack;
    // ---- 
    bool isMovementLocked;

    // ----- managers ---------------------------------------------------------
    public S_ObjectInteraction pickupManager;
    // public Inventory inventory;

    // ----- components -------------------------------------------------------
    public BasicAttack basicAttack;
    Vector2 movementInput;
    Rigidbody2D rb;
    Animator animator;
    SpriteRenderer spriteRenderer;
    List<RaycastHit2D> castCollisions = new List<RaycastHit2D>();

    // ------------------------------------------------------------------------
    // ----- Serializations ---------------------------------------------------
    // ------------------------------------------------------------------------
    // [SerializeField] private UI_Inventory uiInventory;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        // inventory = new Inventory();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        if (isMovementLocked) { return; }
        // if movement input is not 0, try to move
        // Debug.Log(movementInput.x, movementInput.y);
        bool canMove = false;
        if (movementInput != Vector2.zero)
        {
            canMove = TryMove(movementInput);
            if (!canMove)
            {
                canMove = TryMove(new Vector2(movementInput.x, 0));
            }
            if (!canMove)
            {
                canMove = TryMove(new Vector2(0, movementInput.y));
            }
            animator.SetBool("isMoving", canMove);
        }
        else
        {
            animator.SetBool("isMoving", false);
        }
        // setting animation direction
        if (movementInput.x < 0)
        {
            spriteRenderer.flipX = true;
        }
        else
        {
            spriteRenderer.flipX = false;
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

    void OnFire()
    {
        // DoStressTest();
        animator.SetTrigger("basicAttack");
        // print("fire pressed");
    }

    void DoStressTest()
    {
        List<int> l = new List<int>();
        int yirmimilyon = 20000000;
        for (int ii = 0; ii < yirmimilyon; ii++)
        {
            l.Add(Random.Range(5, 10));
        }
        print(l[Random.Range(0, yirmimilyon)]);
    }

    public void BasicAttack()
    {
        LockMovement();

        if (spriteRenderer.flipX == true)
        {
            basicAttack.AttackLeft();
        }
        else
        {
            basicAttack.AttackRight();
        }

    }

    public void EndAttack()
    {
        UnlockMovement();
        basicAttack.StopAttack();
    }

    public void LockMovement()
    {
        isMovementLocked = true;
    }

    public void UnlockMovement()
    {
        isMovementLocked = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        pickupManager.HandlePlayerCollision(collision);
        //I_Pickup item = collision.GetComponent<I_Pickup>();
        //if (item == null) { return; }
        //item.Pickup();
        //if (collision.tag == "Interractable")
        //{
        //    Debug.Log("Interract!");
        //}
    }

}
