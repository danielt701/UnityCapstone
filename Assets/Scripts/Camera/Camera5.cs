using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera5 : MonoBehaviour
{
    [SerializeField]

    private Transform targetToFollow;



    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(targetToFollow.position.x, 1.85f, 220.5f),
                                          Mathf.Clamp(targetToFollow.position.y, 0.63f, 3.19f),
                                          transform.position.z);
    }
}
