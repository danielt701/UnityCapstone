using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPos2 : MonoBehaviour
{
    private GameCheck2 gm2;

    void Start()
    {
        gm2 = GameObject.FindGameObjectWithTag("GM2").GetComponent<GameCheck2>();
        transform.position = gm2.lastCheckPointPos;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
