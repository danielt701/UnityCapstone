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
        transform.position = new Vector3(Mathf.Clamp(targetToFollow.position.x, -0.25f, 219f),
                                          Mathf.Clamp(targetToFollow.position.y, -3f, 82.6f),
                                          transform.position.z);
    }
}
