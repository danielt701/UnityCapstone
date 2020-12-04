using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
 public void Hasquit()
    {
        Application.Quit();
        Debug.Log("game is quitting");
    }


}
