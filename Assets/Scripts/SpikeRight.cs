using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeRight : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody2D rb;
    private Vector2 screenBounds;


    private void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(speed, 0);

        transform.localRotation = Quaternion.Euler(0, 0, -90);



    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("GAP"))
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Platform"))
        {
            GetComponent<PolygonCollider2D>().enabled = true;
        }
    }
}
