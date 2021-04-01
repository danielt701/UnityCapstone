using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour
{

    public Transform Spawnpoint;
    public GameObject Prefab;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        Instantiate(Prefab, Spawnpoint.position, Spawnpoint.rotation);
    }
}
