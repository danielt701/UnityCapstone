using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class HealthBar : MonoBehaviour
{
    public Image img;
    public Animator animator;

    private float damageTimeout = 2f;
    private bool canTakeDamage = true;
    private bool canGetHealth = true;

    [SerializeField] Image LifeFill;

    float Life = 1f;  // life between 0 and 1

    public AudioSource audioSource;
    public AudioClip ClydeYelp;
    public AudioClip EnemyAttack;
    public AudioClip PowerUpUse;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals ("Enemy"))
        {
            RemoveLife();

            canTakeDamage = false;

            StartCoroutine(TimeDelay());


            audioSource.PlayOneShot(ClydeYelp, 0.8f);
            audioSource.PlayOneShot(EnemyAttack, 0.7f);
        }

        if (other.tag.Equals ("Bone"))
        {
            AddLife();

            canGetHealth = false;

            StartCoroutine(TimeDelay());

            audioSource.PlayOneShot(PowerUpUse, 2.0f);
        }

       
    }

    IEnumerator TimeDelay()
    {
        yield return new WaitForSeconds(0.8f);
        canTakeDamage = true;
        canGetHealth = true;
    }
    

    void AddLife ()
    {
        if (canGetHealth && Life < 1f)
        {
            Life += 0.35f;
            LifeFill.fillAmount = Life;
        } 
    }


    public void RemoveLife()
    {
        if (canTakeDamage && Life > 0f)
        {
            Life -= 0.35f;
            LifeFill.fillAmount = Life;
            animator.SetBool("isHurt", true);

           
        }


        if (Life <= 0f)
        {
            animator.SetTrigger("isDead");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
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
    
            if (canGetHealth && tag == "Bone")
                {
                    if (Life < 1f)
                    {
                        Life += 0.35f;
                        LifeFill.fillAmount = Life;
                       
                        
                    
                    }
                }
            }
        }
        
    }




}
