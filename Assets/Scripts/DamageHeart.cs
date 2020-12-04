using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageHeart : MonoBehaviour
{

    public GameObject itemDestroy;
    public GameObject itemDestroy2;
    public GameObject itemDestroy3;

    public void OnCollisionEnter2D(Collision2D collision)
    { 


            if (collision.gameObject.tag == "Enemy")
            {
                Destroy(itemDestroy);
            }
           
                
            
            
       
    }
}
