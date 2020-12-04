using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisButton : MonoBehaviour
{

    public GameObject invisibilityOn;
    private Transform player;


    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

    }

    public void Use()
    {
        Instantiate(invisibilityOn, player.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
