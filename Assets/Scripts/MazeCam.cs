using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeCam : MonoBehaviour
{
    [SerializeField]

    private Transform targetToFollow;



    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(targetToFollow.position.x, -4.64f, 3.5f),
                                          Mathf.Clamp(targetToFollow.position.y, -7.15f, 6.60f),
                                          transform.position.z);
    }
}
