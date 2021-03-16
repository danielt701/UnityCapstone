using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPosition : MonoBehaviour
{
    private GameCheckpoint gm;

    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameCheckpoint>();
        transform.position = gm.lastCheckPointPos;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

}
