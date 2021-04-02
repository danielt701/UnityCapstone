using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;

    public GameObject continueButton;

    private bool hasCoroutineStarted = false;

    private bool isCompleted = false;

    public GameObject dialogueManager;
    public DialogueManager ManagerScript;
    public GameObject thisdialogue;

    private void Start()
    {
        //StartCoroutine(Type());
        
    }

    private void Update()
    {
        if (ManagerScript == null)
        {
            Debug.Log(dialogueManager);
            DialogueManager ManagerScript = dialogueManager.GetComponent<DialogueManager>();
        }
        if (textDisplay.text == sentences[index])
        {
            continueButton.SetActive(true);
        }
    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.CompareTag("Player") && !hasCoroutineStarted)
        {
            ManagerScript.currentDialogue = thisdialogue;
            hasCoroutineStarted = true;
            StartCoroutine(Type());
        }
    }

    IEnumerator Type()
    {
        foreach(char letter in sentences[index].ToCharArray())
        {
            isCompleted = false;
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
        isCompleted = true;

        yield return null;
    }

    public void NextSentence()
    {
        if(isCompleted == true)
        {
            continueButton.SetActive(true);

            if (index < sentences.Length - 1)
            {
                index++;
                textDisplay.text = "";
                StartCoroutine(Type());
            }
            else
            {
                textDisplay.text = "";
                continueButton.SetActive(false);
            }
        }
            
    }
    
}
