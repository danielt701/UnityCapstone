using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class HealthBar : MonoBehaviour
{
    public Image img;
    public Animator animator;

    [SerializeField] Image LifeFill;

    float Life = 1f;  // life between 0 and 1


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals ("Enemy"))
        {
            RemoveLife();
        }

        if (other.tag.Equals ("Bone"))
        {
            AddLife();
        }

       
    }

    void AddLife ()
    {
        if (Life < 1f)
        {
            Life += 0.2f;
            LifeFill.fillAmount = Life;
        } 
    }


    public void RemoveLife()
    {
        if (Life > 0f)
        {
            Life -= 0.2f;
            LifeFill.fillAmount = Life;
            animator.SetBool("isHurt", true);
        }


        if (Life <= 0f)
        {
            animator.SetTrigger("isDead");
            SceneManager.LoadScene("PickUpTest 1");
        }


    }

    public void Stophurt()
    {
        animator.SetBool("isHurt", false);
    }


    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {

                Debug.Log(hit.transform.name);
    
            if (tag == "Bone")
                {
                    if (Life < 1f)
                    {
                        Life += 0.2f;
                        LifeFill.fillAmount = Life;
                    }
                }
            }
        }
        
    }




}
