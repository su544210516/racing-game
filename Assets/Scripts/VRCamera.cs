using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRCamera : MonoBehaviour
{
    public Transform VR;
    public Vector3 InitialPosition;
    void OnMoveUp()
    {
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y + 0.01f, transform.localPosition.z);
    }
    void OnMoveDown()
    {
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y - 0.01f, transform.localPosition.z);
    }
    void OnMoveLeft()
    {
        transform.localPosition = new Vector3(transform.localPosition.x - 0.01f, transform.localPosition.y, transform.localPosition.z);
    }
    void OnMoveRight()
    {
        transform.localPosition = new Vector3(transform.localPosition.x + 0.01f, transform.localPosition.y, transform.localPosition.z);
    }
    void OnMoveForward()
    {
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, transform.localPosition.z + 0.01f);
    }
    void OnMoveBack()
    {
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, transform.localPosition.z - 0.01f);
    }
    void OnResetCamera()
    {
        print("test");
        transform.localPosition = new Vector3(InitialPosition.x - VR.localPosition.x, InitialPosition.y - VR.localPosition.y, InitialPosition.z - VR.localPosition.z);
    }
    // Start is called before the first frame update
    void Start()
    {
        InitialPosition = transform.localPosition;
        transform.localPosition = new Vector3(InitialPosition.x - VR.localPosition.x, InitialPosition.y - VR.localPosition.y, InitialPosition.z - VR.localPosition.z);
    }
}
