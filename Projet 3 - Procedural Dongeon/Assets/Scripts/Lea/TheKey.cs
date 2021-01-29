using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheKey : MonoBehaviour
{
    public float rayon;
    public Vector2 direc;
    float dist;
    LayerMask mask;
    Transform target;
    Rigidbody2D rb2D;

    public void SetUp()
    {
        if (target == null)
        {
            target = GameObject.Find("Player(Clone)").GetComponent<Transform>();
        }

        mask = LayerMask.GetMask("Door");

        FindDoor();
    }


    public void FindDoor()
    {
        RaycastHit2D hit = Physics2D.CircleCast(target.position, rayon, direc, dist, mask);

        if (hit.collider != null)
        {
            Destroy(hit.collider.gameObject);

            Destroy(this.gameObject);
        }
    }
}
