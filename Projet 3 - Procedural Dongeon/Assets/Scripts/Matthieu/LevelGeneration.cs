using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGeneration : MonoBehaviour
{
    public Transform[] startingPositions;
    public GameObject[] rooms;
    public GameObject player;
    
    int direction;
    public float repeatSpeed=0.25f;
    public float moveAmount = 5;
    public bool isStopped = false;
    public LayerMask roomLayer;
    int downCounter;

    List<GameObject> roomSpawned = new List<GameObject>();

    [Header("Level Limits")]
    public float minX;
    public float maxX;
    public float maxY;


    private void Start()
    {
        int randStartingPos = Random.Range(0, startingPositions.Length);



        transform.position = startingPositions[randStartingPos].position;
        Instantiate(player, transform.position, Quaternion.identity);
        Instantiate(rooms[0], transform.position, Quaternion.identity);

        direction = Random.Range(1, 6);

        InvokeRepeating("Move", 0.5f, repeatSpeed);
    }

    private void Update()
    {
        int lastRoomNumber = roomSpawned.Count;

        if (isStopped)
        {
            if (lastRoomNumber >= 4)
            {
                GameObject lastRoom = roomSpawned[lastRoomNumber - 1];

                lastRoom.GetComponent<RoomTypes>().isLocked = true;
            }
            CancelInvoke();
        }

        Debug.Log(roomSpawned.Count);

      

     


    }

    void Move()
    {
        if (direction == 1 || direction == 2)
        {
            //Move Right
            if (transform.position.x < maxX)
            {
                downCounter = 0;
                Vector2 newPos = new Vector2(transform.position.x + moveAmount, transform.position.y);
                transform.position = newPos;

                int rand = Random.Range(0, rooms.Length);
                SpawnObject(rand);

                direction = Random.Range(1, 6);
                if (direction == 3)
                {
                    direction = 2;
                }
                else if (direction == 4)
                {
                    direction = 5;
                }
            }
            else
            {
                direction = 5;
            }

           
        }

        else if (direction == 3 || direction == 4)

        {
            //Move Left

            

            if (transform.position.x > maxX)
            {
                downCounter = 0;
                Vector2 newPos = new Vector2(transform.position.x - moveAmount, transform.position.y);
                transform.position = newPos;

                int rand = Random.Range(0, rooms.Length);
                SpawnObject(rand);

                direction = Random.Range(3, 6);

            }
            else
            {
                direction = 5;
            }
        }

        else if (direction == 5)

        {
            //Move Down

            downCounter++;

            Collider2D roomDetection = Physics2D.OverlapCircle(transform.position, 1f, roomLayer);


            if(roomDetection.GetComponent<RoomTypes>().type!=1 && roomDetection.GetComponent<RoomTypes>().type != 3)
            {
                if (downCounter >= 2)
                {
                    roomDetection.GetComponent<RoomTypes>().RoomDestruction();
                    SpawnObject(3);
                }
                else
                {
                    roomDetection.GetComponent<RoomTypes>().RoomDestruction();
                    int randBottomRoom = Random.Range(1, 4);
                    if (randBottomRoom == 2)
                    {
                        randBottomRoom = 1;
                    }
                    SpawnObject(randBottomRoom);
                }
            }

            if (transform.position.y > maxY)
            {
                Vector2 newPos = new Vector2(transform.position.x, transform.position.y - moveAmount);
                transform.position = newPos;

                int rand = Random.Range(2, 4);
                SpawnObject(rand);

                direction = Random.Range(1, 6);
                if (direction == 5)
                {
                    if (transform.position.y > maxY)
                    {
                        direction = Random.Range(1, 5);
                    }
                    else
                    {
                        isStopped = true;
                    }
                 
                 
                }
                else if (direction == 3 || direction == 4)
                {
                    if (transform.position.x > maxX)
                    {
                        direction = 3;
                    }
                    else
                    {
                        direction = 5;
                    }
                } else if (direction == 1 || direction == 2)
                {
                    if (transform.position.x < maxX)
                    {
                         direction = 1;
                    }
                    else
                    {
                        direction = 5;
                    }
                }

            }
            else
            {
                isStopped = true;
            }
          
        }

      

        

    }

    void SpawnObject(int number)
    {
     

        roomSpawned.Add(Instantiate(rooms[number], transform.position, Quaternion.identity) as GameObject);

       
      
     
    }
}
