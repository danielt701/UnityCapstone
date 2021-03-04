using UnityEngine;

public class LockPosition : MonoBehaviour
{
    [Header("Lock position")]
    public bool posX;
    public bool posY;
    public bool posZ;

    [Header("Lock rotation")]
    public bool rotX;
    public bool rotY;
    public bool rotZ;
    public bool rotW;

    Vector3 targetPos;
    Quaternion targetRot;

    private void Start()
    {
        targetPos = transform.position;
        targetRot = transform.rotation;
    }

    private void Update()
    {
        #region PositionLock

        Vector3 curPos;

        if (posX)
        {
            transform.position = new Vector3(targetPos.x, transform.position.y, transform.position.z);
            //transform.position = curPos;
        }
        else if (posY)
        {
            transform.position = new Vector3(transform.position.x, targetPos.y, transform.position.z);
            //transform.position = curPos;
        }
        else if (posZ)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, targetPos.z);
            //transform.position = curPos;
        }
        else if (posX && posY)
        {
            transform.position = new Vector3(targetPos.x, targetPos.y, transform.position.z);
            //transform.position = curPos;
        }
        else if (posX && posZ)
        {
            transform.position = new Vector3(targetPos.x, transform.position.y, targetPos.z);
            //transform.position = curPos;
        }
        else if (posY && posZ)
        {
            transform.position = new Vector3(transform.position.x, targetPos.y, targetPos.z);
            //transform.position = curPos;
        }
        else if (posX && posY && posZ)
        {
            transform.position = new Vector3(targetPos.x, targetPos.y, targetPos.z);
            //transform.position = curPos;
        }

        #endregion

        #region RotationLock

        Quaternion curRot;

        if (rotX)
        {
            transform.rotation = new Quaternion(targetRot.x, transform.rotation.y, transform.rotation.z, transform.rotation.w);
            //transform.rotation = curRot;
        }
        else if (rotY)
        {
            transform.rotation = new Quaternion(transform.rotation.x, targetRot.y, transform.rotation.z, transform.rotation.w);
            //transform.rotation = curRot;
        }
        else if (rotZ)
        {
            transform.rotation = new Quaternion(transform.rotation.x, transform.rotation.y, targetRot.z, transform.rotation.w);
            //transform.rotation = curRot;
        }
        else if (rotW)
        {
            transform.rotation = new Quaternion(transform.rotation.x, transform.rotation.y, transform.rotation.z, targetRot.w);
            //transform.rotation = curRot;
        }
        else if (rotX && rotY)
        {
            transform.rotation = new Quaternion(targetRot.x, targetRot.y, transform.rotation.z, transform.rotation.w);
            //transform.rotation = curRot;
        }
        else if (rotX && rotZ)
        {
            transform.rotation = new Quaternion(targetRot.x, transform.rotation.y, targetRot.z, transform.rotation.w);
            //transform.rotation = curRot;
        }
        else if (rotY && rotZ)
        {
            transform.rotation = new Quaternion(transform.rotation.x, targetRot.y, targetRot.z, transform.rotation.w);
            //transform.rotation = curRot;
        }
        else if (rotX && rotW)
        {
            transform.rotation = new Quaternion(targetRot.x, transform.rotation.y, transform.position.z, targetRot.w);
            //transform.rotation = curRot;
        }
        else if (rotY && rotW)
        {
            transform.rotation = new Quaternion(transform.rotation.x, targetRot.y, transform.rotation.z, targetRot.w);
            //transform.rotation = curRot;
        }
        else if (rotZ && rotW)
        {
            transform.rotation = new Quaternion(transform.rotation.x, transform.rotation.y, targetRot.z, targetRot.w);
            //transform.rotation = curRot;
        }
        else if (rotX && rotY && rotW)
        {
            transform.rotation = new Quaternion(targetRot.x, targetRot.y, transform.rotation.z, targetRot.w);
            //transform.rotation = curRot;
        }
        else if (rotX && rotZ && rotY)
        {
            transform.rotation = new Quaternion(targetRot.x, targetRot.y, targetRot.z, transform.rotation.w);
            //transform.rotation = curRot;
        }
        else if (rotX && rotW && rotZ)
        {
            transform.rotation = new Quaternion(targetRot.x, transform.rotation.y, targetRot.z, targetRot.w);
            //transform.rotation = curRot;
        }
        else if (rotY && rotZ && rotW)
        {
            transform.rotation = new Quaternion(transform.rotation.x, targetRot.y, targetRot.z, targetRot.w);
            //transform.rotation = curRot;
        }
        else if (rotX && rotY && rotZ && rotW)
        {
            transform.rotation = new Quaternion(targetRot.x, targetRot.y, targetRot.z, targetRot.w);
            //transform.rotation = curRot;
        }

        #endregion
    }
}