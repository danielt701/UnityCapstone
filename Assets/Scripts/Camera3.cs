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
        transform.position = new Vector3(Mathf.Clamp(targetToFollow.position.x, -.20f, 226.7f),
                                          Mathf.Clamp(targetToFollow.position.y, -2f, 87f),
                                          transform.position.z);
    }
}
