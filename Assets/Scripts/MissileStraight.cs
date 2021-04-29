using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileStraight : MonoBehaviour
{
    public float speed = 10.0f;
    public float faster = 50.0f;
    private Rigidbody2D rb;
    private Vector2 screenBounds;

    EdgeCollider2D platforms;

    PolygonCollider2D missile;


    private void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed, 0);
    

    }

    private void Update()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("GAP"))
        {
            Destroy(gameObject);
        }

        if (collision.CompareTag("Player"))
        {
            //Destroy(gameObject);
        }


    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Platform"))
        {
            GetComponent<BoxCollider2D>().enabled = true;
        }
    }

}
