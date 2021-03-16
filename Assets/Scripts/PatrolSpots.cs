using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolSpots : MonoBehaviour
{
    public float speed;
    private float waitTime;
    public float startWaitTime;
    public bool mustPatrol;

    public Transform[] moveSpots;
    private int randomSpot;
    
   
    

    // Start is called before the first frame update
    void Start()
    {
        randomSpot = Random.Range(0, moveSpots.Length);
        mustPatrol = true;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, moveSpots[randomSpot].position, speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, moveSpots[randomSpot].position) < 0.1f)
        {
            if(waitTime <= 0)
            {
                randomSpot = Random.Range(0, moveSpots.Length);
                waitTime = startWaitTime;
            }
            else
            {
                waitTime -= Time.deltaTime;
            }
        }
    }

    void Flip()
    {
        mustPatrol = false;
        transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
        mustPatrol = true;
    }


}
