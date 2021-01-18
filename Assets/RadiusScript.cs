using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadiusScript : MonoBehaviour
{
    public GameObject playerRadius;

    public float speed;

    private Transform target;

    private Transform Enemystay;

    private bool working;

    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        Enemystay = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Transform>();

        working = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        working = true;
    }

    private void Update()
    {
        if(working == true)
        {
            if (Vector2.Distance(transform.position, target.position) > 3)
            {
                transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            }
        }
      
    }
}
