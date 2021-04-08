using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint2andHalf : MonoBehaviour
{
    private GameCheck2Half gm2half;

    private void Start()
    {
        gm2half = GameObject.FindGameObjectWithTag("GM2half").GetComponent<GameCheck2Half>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            gm2half.lastCheckPointPos = transform.position;
        }
    }
}
