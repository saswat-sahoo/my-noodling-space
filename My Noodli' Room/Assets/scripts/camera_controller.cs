using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_controller : MonoBehaviour
{
    // Update is called once per frame
    [SerializeField] 
    private CharacterController controller;
    [SerializeField] 
    private float speed = 10f;
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * y;
        move = move.normalized;
        if (move.magnitude > 0)
        {
            Move(move);
        }
    }

    void Move(Vector3 move)
    {
        controller.Move(move * speed * Time.deltaTime);
    }
}
