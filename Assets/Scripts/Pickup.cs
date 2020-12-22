using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    private Inventory inventory;
    public GameObject itemButton;

    public AudioSource audioSource;
    public AudioClip PowerUpGet;

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.isFull[i] == false)
                {
                    Destroy(gameObject);

                    audioSource.PlayOneShot(PowerUpGet, 0.8f);
                   
                }
            }
        }
    }
}
