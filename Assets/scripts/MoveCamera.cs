using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class MoveCamera : NetworkBehaviour
{
    public Transform cameraPosition;
    // Update is called once per frame


    private void Start()
    {
        if (!IsOwner) return;
        transform.position = cameraPosition.position;
        
    }

    void Update()
    {
        if (!IsOwner) return;
        transform.position = cameraPosition.position;
    }
}
