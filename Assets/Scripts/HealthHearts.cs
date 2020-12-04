using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthHearts : MonoBehaviour
{
    public int health;
    public int numOfHearts;

    public Image[] hearts;
    public Sprite fullHearts;
    public Sprite emptyHeart;

    private void Update()
    {

        if(health > numOfHearts)
        {
            health = numOfHearts;
        }
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < health)
            {
                hearts[i].sprite = fullHearts;

            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }


            if (i < numOfHearts)
            {
                hearts[i].enabled = true;

            }
            else
            {
                hearts[i].enabled = false;
            }

        }
 

    }

   /* void RemoveLife()
    {
        if(health > numOfHearts)
        {
            health = numOfHearts;
           
        }
        for (int h = 0; h < hearts.Length; h++)
            if(h < )
            {

            }
    }
    */


    private void OnTriggerEnter2D(Collider2D enem)
    {
        if (enem.gameObject.tag.Equals("Enemy"))
        {
            SceneManager.LoadScene("PickUpTest");
        }
    }


}
