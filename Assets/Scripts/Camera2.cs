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
        transform.position = new Vector3(Mathf.Clamp(targetToFollow.position.x, -15.8f, 145f),
                                         Mathf.Clamp(targetToFollow.position.y, 2.25f, 3.45f),
                                         transform.position.z);
    }
}
