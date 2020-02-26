using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float mouseX;
    public float rotationSpeed = 2;

    void Update()
    {
        mouseX = Input.GetAxisRaw("Mouse X");

        //rotate on the Y axis
        transform.Rotate(Vector3.up, mouseX * rotationSpeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }
}
