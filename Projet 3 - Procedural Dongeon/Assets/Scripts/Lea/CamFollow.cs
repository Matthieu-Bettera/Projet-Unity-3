using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    Transform target;
    Rigidbody2D rb2D;

    LayerMask mask;

    public float rayon;
    public Vector2 direc;
    public float dist;

    void Start()
    {
        mask = LayerMask.GetMask("Room");
    }

    void Update()
    {
        if (target == null)
        {
            target = GameObject.Find("Player(Clone)").GetComponent<Transform>();
            rb2D = GameObject.Find("Player(Clone)").GetComponent<Rigidbody2D>();

            // Start place
            transform.position = new Vector3(target.position.x, target.position.y, -10f);
        }

        RaycastHit2D hit = Physics2D.CircleCast(target.position, rayon, direc, dist, mask);

        if (hit.collider != null)
        {
            Debug.Log("esdrfbe");

            transform.position = new Vector3(hit.transform.position.x, hit.transform.position.y, -10f);
        }

    }

}
