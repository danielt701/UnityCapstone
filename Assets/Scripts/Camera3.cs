using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera3 : MonoBehaviour
{
    [SerializeField]

    private Transform targetToFollow;
   
  

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(targetToFollow.position.x, 14.25f, 226.7f),
                                          Mathf.Clamp(targetToFollow.position.y, 0.96f, 19.63f),
                                          transform.position.z);
    }
}
