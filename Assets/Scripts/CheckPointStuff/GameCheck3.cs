using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCheck3 : MonoBehaviour
{
    private static GameCheck3 instance;
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
