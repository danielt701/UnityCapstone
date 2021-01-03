using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTimer : MonoBehaviour
{
    public Transform Player;
    int MoveSpeed = 3;
    int MaxDist = 10;
    int MinDist = 2;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Player);

        if(Vector3.Distance(transform.position, Player.position) >= MinDist)
        {
            transform.position += transform.forward * MoveSpeed * Time.deltaTime;
        }


        if(Vector3.Distance(transform.position, Player.position) <= MaxDist)
        {

        }
    
    }
}
