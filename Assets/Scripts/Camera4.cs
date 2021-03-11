using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera4 : MonoBehaviour
{
    [SerializeField]

    private Transform targetToFollow;



    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(targetToFollow.position.x, 9.1f, 186.1f),
                                          Mathf.Clamp(targetToFollow.position.y, -1.5f, 40.6f),
                                          transform.position.z);
    }
}
