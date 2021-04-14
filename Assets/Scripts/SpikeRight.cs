﻿using System.Collections;
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(this.gameObject);
    }
}