using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPos4 : MonoBehaviour
{
    private GameCheck4 gm4;

    void Start()
    {
        gm4 = GameObject.FindGameObjectWithTag("GM4").GetComponent<GameCheck4>();
        transform.position = gm4.lastCheckPointPos;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
