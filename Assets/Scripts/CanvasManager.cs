using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class CanvasManager : MonoBehaviour
{
    [SerializeField] private Canvas webCanvas;
    [SerializeField] private Canvas mobileCanvas;
    
    void Update()
    {
        webCanvas.gameObject.SetActive(Screen.width > Screen.height);
        mobileCanvas.gameObject.SetActive(Screen.width <= Screen.height);
    }
}
