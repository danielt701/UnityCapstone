using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TalkPopup : MonoBehaviour
{

    public string popUp;

    public AudioSource audioSource;
    public AudioClip NPCVoice;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            PopupSystem pop = GameObject.FindGameObjectWithTag("GameManager").GetComponent<PopupSystem>();
            pop.PopUp(popUp);
            audioSource.PlayOneShot(NPCVoice, 1.0f);
        }
    }
}
