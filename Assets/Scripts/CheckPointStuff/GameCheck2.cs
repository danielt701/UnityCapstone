using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCheck2 : MonoBehaviour
{
    private static GameCheck2 instance;
    public Vector2 lastCheckPointPos;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
