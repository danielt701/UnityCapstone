using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TalkPopup : MonoBehaviour
{

    public string popUp;
    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            PopupSystem pop = GameObject.FindGameObjectWithTag("GameManager").GetComponent<PopupSystem>();
            pop.PopUp(popUp);
        }
    }
}
