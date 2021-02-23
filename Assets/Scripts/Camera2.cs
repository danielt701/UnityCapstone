using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera2 : MonoBehaviour
{
    [SerializeField]

    private Transform targetToFollow;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(targetToFollow.position.x, -24.7f, 155.2f),
                                         Mathf.Clamp(targetToFollow.position.y, -0.8f, 6.8f),
                                         transform.position.z);
    }
}
