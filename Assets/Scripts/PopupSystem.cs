using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PopupSystem : MonoBehaviour
{
    public GameObject popUpBox;
    public Animator popanimator;
    public TMP_Text popUpText;

    public void PopUp(string text)
    {
        popUpBox.SetActive(true);
        popUpText.text = text;
        popanimator.SetTrigger("pop");

    }
}
