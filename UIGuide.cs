using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIGuide : MonoBehaviour
{

    Camera cam;
    bool clickedGuide = false;

    [SerializeField]
    private GameObject leftCharacterButton;
    [SerializeField]
    private GameObject rightCharacterButton;
    [SerializeField]
    private GameObject clickedBack;
    [SerializeField]
    private GameObject[] listOfMenuItems;
    [SerializeField]
    private GameObject[] cameras;
    [SerializeField]
    private GameObject mainCamera;
    public GameObject spinButton;

    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
        leftCharacterButton.SetActive(false);
        rightCharacterButton.SetActive(false);
        mainCamera.SetActive(false);
        clickedBack.SetActive(false);
        spinButton.SetActive(false);
    }

    void Update() {
        if(clickedGuide){
            leftCharacterButton.SetActive(true);
            rightCharacterButton.SetActive(true);
            clickedBack.SetActive(true);
            spinButton.SetActive(true);
            disappearMenu();
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
        mainCamera.SetActive(false);
    }

    public void changeAngleGuide(){
        if(clickedGuide == false){
            mainCamera.SetActive(true);
            clickedGuide = true;
        }
    }

    public void nextItem(){
        if(mainCamera.transform.position.z < 500){
            mainCamera.transform.position += new Vector3(0, 0, 250);
        }
    }

    public void previousItem(){
        if(mainCamera.transform.position.z > -300){
            mainCamera.transform.position += new Vector3(0, 0, -250);
        }
    }

    public void centreCamera(){
        clickedGuide = false;
        leftCharacterButton.SetActive(false);
        rightCharacterButton.SetActive(false);
        clickedBack.SetActive(false);
        spinButton.SetActive(false);
        appearMenu();
    }

}
