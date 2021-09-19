using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveplayer : MonoBehaviour
{
    private float speed = 6.0f, mouseSenstivity = 1.0f;
    private float verticalClamp, deltaX, deltaZ, mouseYMove, mouseXMove;

    void Update()
    {
        //move with arrow keyboard
        deltaX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        deltaZ = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(new Vector3(deltaX, 0, deltaZ));

        //rotate with mouse
        mouseYMove = Input.GetAxis("Mouse Y") * mouseSenstivity;
        mouseXMove = Input.GetAxis("Mouse X") * mouseSenstivity;
        verticalClamp += mouseYMove;
        if (verticalClamp > 30.0f) { ClampVerticalAngle(30); }
        else if (verticalClamp < -30.0f) { ClampVerticalAngle(-30); }
        transform.Rotate(-mouseYMove, mouseXMove, 0);
    }

    void ClampVerticalAngle(float value)
    {
        verticalClamp = value;
        mouseYMove = 0.0f;
        Vector3 currentEulerAngle = transform.eulerAngles;
        currentEulerAngle.x = -value;
        transform.eulerAngles = currentEulerAngle;
    }
}
