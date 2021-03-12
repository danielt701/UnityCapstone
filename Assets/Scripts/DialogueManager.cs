using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    public GameObject currentDialogue;
    public int counter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextDialogue()
    {
        currentDialogue.GetComponent<Dialogue>().NextSentence();
    }
}
