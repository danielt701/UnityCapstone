using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint4 : MonoBehaviour
{
    private GameCheck4 gm4;

    private void Start()
    {
        gm4 = GameObject.FindGameObjectWithTag("GM4").GetComponent<GameCheck4>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            gm4.lastCheckPointPos = transform.position;
        }
    }
}
