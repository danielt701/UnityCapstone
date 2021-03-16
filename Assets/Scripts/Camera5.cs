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
        transform.position = new Vector3(Mathf.Clamp(targetToFollow.position.x, 4.29f, 218f),
                                          Mathf.Clamp(targetToFollow.position.y, 2.2f, 4.98f),
                                          transform.position.z);
    }
}
