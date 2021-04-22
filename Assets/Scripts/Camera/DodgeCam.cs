using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DodgeCam : MonoBehaviour
{
    [SerializeField]

    private Transform targetToFollow;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(targetToFollow.position.x, -22.5f, 67f),
                                         Mathf.Clamp(targetToFollow.position.y, 0.02f, 0.16f),
                                         transform.position.z);
    }
}
