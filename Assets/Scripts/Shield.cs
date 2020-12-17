using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    public GameObject shield;

    private bool activeShield;

    private void Start()
    {
        activeShield = false;
        shield.SetActive(false);

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "shield")
        {
            if(!activeShield)
            {
                shield.SetActive(true);
                activeShield = true;

            }
            else
            {
                shield.SetActive(false);
                activeShield = false;
            }
        }
    }

    public bool ActiveShield
    {
        get
        {
            return activeShield;
        }
        set
        {
            activeShield = value;
        }
    }
}
