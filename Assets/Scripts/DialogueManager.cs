using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    public GameObject currentDialogue;
    public int counter;

    public Player Move;

    // Start is called before the first frame update
    void Start()
    {
        Move = GameObject.FindWithTag("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextDialogue()
    {
        currentDialogue.GetComponent<Dialogue>().NextSentence();
    }

    public void dialogueStarted()
    {
        Move.StopMove = true;
    }

    public void dialogueEnded()
    {
        //currentDialogue.GetComponent<Dialogue>().EndDialogue();
        Move.StopMove = false;
    }
}
