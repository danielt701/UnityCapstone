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

    private void OnTriggerExit2D(Collider2D collision)
    {
        Destroy(gameObject);
    }

    public void Use()
    {
        Instantiate(invisibilityOn, player.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
