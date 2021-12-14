using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigidbody;
    float movimiento;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        movimiento = Input.GetAxisRaw("Horizontal");
        animator.SetFloat("HorizontalVelocity",Mathf.Abs(movimiento));

        rigidbody.velocity = new Vector2(movimiento*3,rigidbody.velocity.y);
    
        if(rigidbody.velocity.y == 0)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                rigidbody.AddForce(Vector2.up*300);
            }
        }


        if(movimiento<0)
        {
            transform.localScale = new Vector3(-1,1,1);

        } else if(movimiento>0)
        {
            transform.localScale = new Vector3(1,1,1);
        }

        
    }
}