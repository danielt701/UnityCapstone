using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform playerDog;

    private void FixedUpdate()
    {
        transform.position =  new Vector3(playerDog.position.x, playerDog.position.y, transform.position.z);
    }


}
