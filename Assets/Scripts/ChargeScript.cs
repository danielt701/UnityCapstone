using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChargeScript : MonoBehaviour
{

    private Transform player;
    private float distance;
    public float moveSpeed;
    public float howclose;

    private float rotationX;
    private float rotationY;

    [SerializeField] private Animator myAnimationController;

    // Start is called before the first frame update
    void Start()
    {
        // player = GameObject.FindGameObjectWithTag("Player").transform;

        
    }

   

    // Update is called once per frame
    void Update()
    {
       // distance = Vector2.Distance(player.position, transform.position);


      /*  if(distance <= howclose)
        {
            transform.LookAt(player);
            anim.Play("ChargingEnemy");
        }
        */
       
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            myAnimationController.SetBool("DoCharge2", true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            myAnimationController.SetBool("DoCharge2", false);
        }
    }
}
