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

    //public GameObject endButton;

    private bool hasCoroutineStarted = false;

    private bool isCompleted = false;

    private bool isFinished = false;

    public GameObject dialogueManager;
    public DialogueManager ManagerScript;
    public GameObject thisdialogue;

    public GameObject textBox;

    private void Start()
    {
        //StartCoroutine(Type());
        //textBox = GameObject.Find("TextCover");
        //Debug.Log(textBox);
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
            //textBox.SetActive(true);
            continueButton.SetActive(true);
            //endButton.SetActive(true);
        }

        /*if (textDisplay.text != null)
        {
            textBox.SetActive(true);
        }*/

    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.CompareTag("Player") && !hasCoroutineStarted)
        {
            textBox.SetActive(true);
            ManagerScript.currentDialogue = thisdialogue;
            hasCoroutineStarted = true;
            StartCoroutine(Type());
            ManagerScript.dialogueStarted();
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
            textBox.SetActive(true);

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
                textBox.SetActive(false);
                ManagerScript.dialogueEnded();
            }
        }

    }

    /*public void EndDialogue()
    {
        if(isFinished == true)
        {
            endButton.SetActive(true);
        }
    }*/
    
}
