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

    public AudioSource audioSource;
    public AudioClip Voice;

    private void Start()
    {
        //StartCoroutine(Type());
        //textBox = GameObject.Find("TextCover");
        //Debug.Log(textBox);
        audioSource = GetComponent<AudioSource>();
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
       if (Input.GetKeyDown("space")) ManagerScript.NextDialogue();
        /*if (textDisplay.text != null)
        {on
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
            if (audioSource != null)
            {
                audioSource.PlayOneShot(Voice, 0.8f);
            }
            ManagerScript.dialogueStarted();
        }

    }

/**
    void finishTyping()
    {
        remainingStr = sentences[index].Substring(curLetter);
        foreach (char letter in remainingStr)
            textDisplay.text += letter;
        isCompleted = true;
    }
*/
    IEnumerator Type()
    {
        foreach (char letter in sentences[index].ToCharArray())
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
        //audioSource.Play();
        if (isCompleted == true)
        {
            continueButton.SetActive(true);
            textBox.SetActive(true);

            if (index < sentences.Length - 1)
            {
                index++;
                //audioSource.PlayOneShot(Voice, 0.8f);
                textDisplay.text = "";
                StartCoroutine(Type());
            }
            else
            {
                textDisplay.text = "";
                continueButton.SetActive(false);
                if (audioSource != null)
                {
                    audioSource.Stop();
                }

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
