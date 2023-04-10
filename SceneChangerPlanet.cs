using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerPlanet : MonoBehaviour
{
    float slower = 500; 
    int approach = -950;

    private float delayBeforeLoading = 0.1f;
    private float timeElapsed;
    bool started = false;

    [SerializeField]
    private Camera cam;

    void Update(){
        if(started){
            timeElapsed += Time.deltaTime;
        }
        if (timeElapsed > delayBeforeLoading)
        {
            SceneManager.LoadScene("MuseumScene");
        }
    }

    void OnMouseDown() {
        started = true;
        cam.fieldOfView = Mathf.Lerp(cam.fieldOfView,approach,Time.deltaTime * slower);
    }
}
