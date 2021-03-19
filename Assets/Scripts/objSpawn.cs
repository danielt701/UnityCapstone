using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objSpawn : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody2D rb;

    public float interval;

    private void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, -speed);
       


    }

    private void Update()
    {
       if (interval > 0)
        {
            interval -= Time.deltaTime;
        }
        else
        {
            enabled = false;

            Destroy(gameObject);
        }
    }
}
