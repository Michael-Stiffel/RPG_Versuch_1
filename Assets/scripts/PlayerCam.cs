using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;


public class PlayerCam : NetworkBehaviour
{

    public float sensX;
    public float sensY;

    public Transform orientation;
    public Camera playerCam;

    private float xRotation;
    private float yRotation;


   
    // Start is called before the first frame update
    void Start()
    {
        if (!IsLocalPlayer)
        {
            playerCam.GetComponent<Camera>().enabled = false;
            return;
        }
            
            
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!IsOwner) return;
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        yRotation += mouseX;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        
        transform.rotation = Quaternion.Euler(xRotation, yRotation,0);
        orientation.rotation = Quaternion.Euler(0,yRotation,0);
    }
}
