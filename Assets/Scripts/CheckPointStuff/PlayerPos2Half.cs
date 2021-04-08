using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPos2Half : MonoBehaviour
{
    private GameCheck2Half gm2half;

    void Start()
    {
        gm2half = GameObject.FindGameObjectWithTag("GM2half").GetComponent<GameCheck2Half>();
        transform.position = gm2half.lastCheckPointPos;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
