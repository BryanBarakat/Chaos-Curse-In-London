using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZoomIn : MonoBehaviour
{
    float slower = 5; 
    int init = 65;
    int approach = 35;
    Camera cam;

    [SerializeField]
    private GameObject UILeft;
    bool zoomed = false;

    void Start() {
        cam = GetComponent<Camera>();
        UILeft.SetActive(false);
    }

    public void zooming(){
        if(zoomed == false){
            cam.fieldOfView = Mathf.Lerp(cam.fieldOfView,approach,slower);
            UILeft.SetActive(true);
        }
    }

    public void zoomOut(){
        cam.fieldOfView = Mathf.Lerp(cam.fieldOfView,init,slower);
        UILeft.SetActive(false);
    }
}
