using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invisibility : MonoBehaviour
{

    private SpriteRenderer character;
    private Color col;
    private float activationtime;
    private bool invisible;

    public GameObject vet;
    public GameObject enemy;


    // Start is called before the first frame update
    void Start()
    {
        character = GetComponent<SpriteRenderer>();
        activationtime = 0;
        invisible = false;
        col = character.color;
    }

    // Update is called once per frame
    void Update()
    {
        activationtime += Time.deltaTime;
        if (invisible && activationtime >= 5)
        {
            invisible = false;
            col.a = 1;
            character.color = col;
            vet.GetComponent<Collider2D>().enabled = true;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {


        if(other.tag == "Invisible")
        {
        
            invisible = true;
            activationtime = 0;
            col.a = .2f;
            character.color = col;

            // for hiding player damage

            vet.GetComponent<Collider2D>().enabled = false;

        }

        
    }


}
