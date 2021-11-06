using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam_movement : MonoBehaviour
{
    public float mouseSensitivity = 10f;

    float xRotation = 0f;
    float yRotation = 0f;
    [SerializeField]
    private  Transform Playerbody;
    void Start()
    {
        Cursor.lockState=CursorLockMode.Locked;
    }


    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        yRotation -= mouseX;
        transform.localRotation = Quaternion.Euler(xRotation, -yRotation, 0f);
        //Playerbody.Rotate(Vector3.up * mouseX);

    }
}
