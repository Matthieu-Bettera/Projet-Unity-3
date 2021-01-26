using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectile : MonoBehaviour
{
    public PlayerMovement move;
    [SerializeField] float speed = 10f;
    Rigidbody2D rb;

    public float timeTodestroy = 0.5f;


  
    // Update is called once per frame
    void Update()
    {
        Destroy(this.gameObject, timeTodestroy);
    }


    public void MoveProjectile()
    {
        Vector2 direction = move.lastMove.normalized;

        rb.velocity = new Vector2(direction.x * speed, direction.y * speed);
    }

    public void FindMove(GameObject moveHolder)
    {
        rb = this.GetComponent<Rigidbody2D>();
        move = moveHolder.GetComponent<PlayerMovement>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ennemi")
        {
            Debug.Log("contact");
        }
    }
}
