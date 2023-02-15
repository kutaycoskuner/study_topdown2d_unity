using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicAttack : MonoBehaviour
{
    public Collider2D attackCollider;
    Vector2 rightAttackOffset;

    public float damage = 2;

    // Start is called before the first frame update
    void Start()
    {
        // attackCollider = GetComponent<Collider2D>();
        rightAttackOffset = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AttackRight()
    {
        // print("Attack Right");
        attackCollider.enabled = true;
        transform.localPosition = rightAttackOffset;
    }

    public void AttackLeft()
    {
        // print("Attack Left");
        attackCollider.enabled = true;
        transform.localPosition = new Vector3(rightAttackOffset.x * -1, rightAttackOffset.y);
    }

    public void StopAttack()
    {
        attackCollider.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // print("touched");
        if (other.tag == "Enemy")
        {
            // todo deal damage to the enemy
            SpriteBehaviour enemy = other.GetComponent<SpriteBehaviour>();
            if (enemy != null)
            {
                enemy.TakeDamage(damage);
            }
        }
    }
}
