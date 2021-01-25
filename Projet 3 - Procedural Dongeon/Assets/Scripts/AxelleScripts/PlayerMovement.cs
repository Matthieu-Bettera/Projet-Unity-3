using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   //script de mouvement sur 2 axis
    [SerializeField] private float speed = 5f;

    private float xMove = 0f;
    private float yMove = 0f;
    private Vector2 moveVector;
    private Rigidbody2D _rigidBody2D;

    public Vector2 lastMove;

    void Start()
    {
        _rigidBody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    { 
        xMove = Input.GetAxisRaw("Horizontal");
        yMove = Input.GetAxisRaw("Vertical");

        moveVector = new Vector2(xMove, yMove);
    }
    void FixedUpdate()
    { 
        if (moveVector.magnitude > 1)
        { 
            moveVector = moveVector.normalized;
        }

        if (moveVector.magnitude != 0)
        {
            if (moveVector.magnitude > 0.5f)
            {
                lastMove = moveVector.normalized;
            }
        }
        
        _rigidBody2D.velocity = moveVector * speed;
    }
}
