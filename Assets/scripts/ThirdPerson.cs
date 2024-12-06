using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPerson : MonoBehaviour
{ 
    public Transform target;                   //camera follows this
    public float distance = 3.0f;              // distance from the taget
    public float sensitivity = 10.0f;          // sensitivity of the camera 
    public float hightOffset = 0.0f;           // hight of the camera relitive to the target

    private float rotationX = 0.0f;            //start vertical rotation
    private float rotationY = 0.0f;            // start horizontal rotation 
    // Start is called before the first frame update
    void Start()
    {
        /*Cursor.lockState = CursorLockMode.Locked;    // mouse will be locked to the cenre of the screen
        Cursor.visible = false;                        // the mouse will not be visible
        */                        
    }
    void HandleCameraInput()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

        rotationY += mouseX;
        rotationX -= mouseY;

        rotationX = Mathf.Clamp(rotationX, -90,90);

        transform.localRotation = Quaternion.Euler(rotationX, rotationY, 0);


    }
    // Update is called once per frame
    void LastUpdate()
    {
        FollowTarget();
    }
    void FollowTarget()
    {
        Vector3 targetPosition = target.position - target.forward * distance + Vector3.up * hightOffset;

        transform.position = targetPosition;
    }
}
