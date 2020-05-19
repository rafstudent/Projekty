using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Camera_script : MonoBehaviour
{

    private Camera cam;

    void Start()
        {
            cam = GetComponent<Camera>();
            cam.depthTextureMode = DepthTextureMode.Depth;
        }
   
}