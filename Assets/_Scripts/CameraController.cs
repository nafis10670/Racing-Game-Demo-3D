using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject Car;
    public Camera NearCam;
    public Camera FarCam;
    
    private float CarX;
    private float CarY;
    private float CarZ;

    private bool isNearCam = true;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            isNearCam = !isNearCam;
            ChangeCamera();
            
        }
    }

    void LateUpdate()
    {
        var eulerAngles = Car.transform.eulerAngles;
        
        CarX = eulerAngles.x;
        CarY = eulerAngles.y;
        CarZ = eulerAngles.z;
        
        this.transform.eulerAngles = new Vector3(0, CarY, 0);
    }

    private void ChangeCamera()
    {
        if (isNearCam)
        {
            NearCam.gameObject.SetActive(true);
            FarCam.gameObject.SetActive(false);
        }
        else
        {
            FarCam.gameObject.SetActive(true);
            NearCam.gameObject.SetActive(false);
        }
    }
}
