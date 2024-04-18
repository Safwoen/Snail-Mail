using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.U2D.IK;

public class CharacterController2D : MonoBehaviour
{
    public const float MOVE_SPEED = 150f;
    private Rigidbody2D rigidbody2D;
    private Vector3 moveDir;
    public Animator anim;

    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();  
    }

    private void Update()
    {
        float moveX = 0f;
        float moveY = 0f;

        if (Input.GetKey(KeyCode.W))
        {
            moveY = +1f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveY = -1f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            moveX = -1f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveX = +1f;
        }
        moveDir = new Vector3 (moveX, moveY).normalized;
        anim.SetFloat("Direction X", moveX) ;
        anim.SetFloat("Direction Y", moveY);
        anim.SetBool("Moving", moveX != 0 || moveY != 0);
       
    }

    private void FixedUpdate()
    {
        rigidbody2D.velocity = moveDir*MOVE_SPEED;
    }
}
