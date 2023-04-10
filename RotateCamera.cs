using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{

    [SerializeField]
    private GameObject cam;
    [SerializeField]
    private GameObject objectUI;
    bool collided = false;
    private UITable tab;

    void Start(){
        objectUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate the object around its local y axis at 1 degree per second
        if(collided){
            cam.transform.Rotate(Vector3.up* Time.deltaTime);
        }
    }
    
    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Player"){
            objectUI.SetActive(true);
        }
        if(other.tag == "Player" && Input.GetKeyDown(KeyCode.E)){
            collided = true;
            objectUI.SetActive(false);
            tab.changeAngle();
        }
    }

    private void OnTriggerExit(Collider other) {
        if(other.tag == "Player"){
            objectUI.SetActive(true);
            collided = false;
        }
    }
}
