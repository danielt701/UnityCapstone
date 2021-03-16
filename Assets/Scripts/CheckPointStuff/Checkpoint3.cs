using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint3 : MonoBehaviour
{
    private GameCheck3 gm3;

    private void Start()
    {
        gm3 = GameObject.FindGameObjectWithTag("GM3").GetComponent<GameCheck3>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            gm3.lastCheckPointPos = transform.position;
        }
    }
}
