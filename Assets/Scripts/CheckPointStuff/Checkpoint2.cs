using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint2 : MonoBehaviour
{
    private GameCheck2 gm2;

    private void Start()
    {
        gm2 = GameObject.FindGameObjectWithTag("GM2").GetComponent<GameCheck2>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            gm2.lastCheckPointPos = transform.position;
        }
    }
}
