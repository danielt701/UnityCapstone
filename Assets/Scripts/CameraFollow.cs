using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    [SerializeField]
    private Transform targetToFollow;

    

    private void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(targetToFollow.position.x, -12f, 262.8f),
                                         Mathf.Clamp(targetToFollow.position.y, -4.15f, 2.35f),
                                         transform.position.z);
    }

   
}
