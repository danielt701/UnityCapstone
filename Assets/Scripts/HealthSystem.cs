using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{

    public GameObject[] hearts; 
    private int life;
    private bool dead;

    private void Start()
    {
        life = hearts.Length;
    }

    void Update()
    {
        if (dead == true)
        {
            // set dead code 
            if(gameObject.tag == "Player")
            {
                Destroy(gameObject);
            }
            Debug.Log("WE ARE DEAD NOW!!");

        }

    }

    public void TakeDamage(int d)
    {
        if (life >= 1)
        {


            life -= d;
            Destroy(hearts[life].gameObject);
            if (life < 1)
            {
                dead = true;
            }

        }
    }

    public void GiveHealth(int d)
    {
        if (life <= 1)
        {
            life += d;
            Instantiate(hearts[life].gameObject);
        }
    }

 
}
