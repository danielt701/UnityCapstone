using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera2half : MonoBehaviour
{
    [SerializeField]

    private Transform targetToFollow;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(targetToFollow.position.x, -14.38f, 159f),
                                         Mathf.Clamp(targetToFollow.position.y, 93.9f, 106.5f),
                                         transform.position.z);
    }
}
