using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class CanvasManager : MonoBehaviour
{
    [SerializeField] private Canvas webCanvas;
    [SerializeField] private Canvas mobileCanvas;

    private int i = 0;
    
    void Update()
    {
        if(i++ > 100)
        {
            i = 0;
            Debug.LogFormat("{0}, {1}", Screen.width, Screen.height);
        }
        
        webCanvas.gameObject.SetActive(Screen.width > Screen.height);
        mobileCanvas.gameObject.SetActive(Screen.width <= Screen.height);
    }
}
