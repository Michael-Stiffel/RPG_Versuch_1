using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.Netcode;

public class NetworkMangerUI : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Button serverButton;
    [SerializeField] private Button clientButton;
    [SerializeField] private Button hostButton;


    private void Awake()
    {
       serverButton.onClick.AddListener(() =>
       {
           NetworkManager.Singleton.StartServer();
       });
       
       clientButton.onClick.AddListener(() =>
       {
           NetworkManager.Singleton.StartClient();
       });
       
       hostButton.onClick.AddListener(() =>
       {
           NetworkManager.Singleton.StartHost();
       });
    }
}
