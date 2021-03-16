using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCheck4 : MonoBehaviour
{
    private static GameCheck4 instance;
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
