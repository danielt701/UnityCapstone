using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PostcardPickup : MonoBehaviour
{
    private float postcard = 0;

    public TextMeshProUGUI textPostcards;



    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "postcard")
        {
            postcard++;

            textPostcards.text = postcard.ToString();

            Destroy(other.gameObject);
        }
    }
}
