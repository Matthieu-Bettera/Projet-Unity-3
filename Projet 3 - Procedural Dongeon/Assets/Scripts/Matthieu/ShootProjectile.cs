using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootProjectile : MonoBehaviour
{

   [SerializeField] GameObject projectile;

    

    public float startTime=0.5f;
    float timer;


    // Start is called before the first frame update
    void Start()
    {
        
        timer = startTime;
    }

    // Update is called once per frame
    void Update()
    {

        if (timer <= 0)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                PlayerProjectile projectileHolder = Instantiate(projectile, transform.position, Quaternion.identity).GetComponent<PlayerProjectile>();
                projectileHolder.FindMove(this.gameObject);
                projectileHolder.MoveProjectile();
                timer = startTime;
            }
        }
        else
        {
            timer -= Time.deltaTime;
        }

       
    }
}
