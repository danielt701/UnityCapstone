using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPos3 : MonoBehaviour
{
    private GameCheck3 gm3;

    void Start()
    {
        gm3 = GameObject.FindGameObjectWithTag("GM3").GetComponent<GameCheck3>();
        transform.position = gm3.lastCheckPointPos;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
