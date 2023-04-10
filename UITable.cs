using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITable : MonoBehaviour
{

    [SerializeField]
    private GameObject cam;
    bool clickedE = false;
    bool clickedKey = false;
    bool collided = false;

    [SerializeField]
    private GameObject clickedBack;
    [SerializeField]
    private GameObject[] listOfMenuItems;
    [SerializeField]
    private GameObject[] cameras;
    [SerializeField]
    private GameObject objectUI;

    // Start is called before the first frame update
    void Start()
    {
        cam.SetActive(false);
        clickedBack.SetActive(false);
        objectUI.SetActive(false);
    }

    void Update() {
        if(clickedE){
            clickedBack.SetActive(true);
            cam.transform.Rotate(Vector3.up* Time.deltaTime * 7);
            disappearMenu();
        }
        if(Input.GetKeyDown(KeyCode.E) && collided){
            clickedKey = true;
            objectUI.SetActive(false);
            changeAngle();
        }
    }

    public void disappearMenu(){
        for(int i = 0;i < listOfMenuItems.Length;i++){
            listOfMenuItems[i].SetActive(false);
        }
        for(int i = 0;i < cameras.Length;i++){
            cameras[i].SetActive(false);
            cameras[i].GetComponent<MouseMovement>().enabled = false;
        }
    }

    public void appearMenu(){
        for(int i = 0;i < listOfMenuItems.Length;i++){
            listOfMenuItems[i].SetActive(true);
        }
        for(int i = 0;i < cameras.Length;i++){
            cameras[i].SetActive(true);
            cameras[i].GetComponent<MouseMovement>().enabled = true;
        }
        cam.SetActive(false);
    }

    public void changeAngle(){
        if(clickedE == false){
            cam.SetActive(true);
            clickedE = true;
        }
    }

    public void centreCamera(){
        clickedE = false;
        clickedKey = false;
        objectUI.SetActive(false);
        clickedBack.SetActive(false);
        appearMenu();
    }

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Player"){
            objectUI.SetActive(true);
            collided = true;
        }
    }

    private void OnTriggerExit(Collider other) {
        if(other.tag == "Player"){
            objectUI.SetActive(false);
            collided = false;
        }
    }

}
