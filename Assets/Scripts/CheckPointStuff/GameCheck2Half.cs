using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCheck2Half : MonoBehaviour
{
    private static GameCheck2Half instance;
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
