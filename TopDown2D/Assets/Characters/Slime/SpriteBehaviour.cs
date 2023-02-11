using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteBehaviour : MonoBehaviour
{
    private float _health = 1;
    public float Health
    {
        get { return _health; }
        set
        {
            _health = value;
            if (_health <= 0)
            {
                Defeated();
            }
        }
    }


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TakeDamage(float damage)
    {
        Health -= damage;
    }
    public void Defeated()
    {
        Destroy(gameObject);
    }
}
