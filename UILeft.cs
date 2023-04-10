using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UILeft : MonoBehaviour
{

    Camera cam;
    bool clickedProcess = false;
    bool clickedPortal = false;
    bool clickedInformation = false;
    bool clickedCharacters = false;

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
    [SerializeField]
    private GameObject[] items;

    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
        mainCamera.SetActive(false);
        leftCharacterButton.SetActive(false);
        rightCharacterButton.SetActive(false);
        clickedBack.SetActive(false);
        for(int i = 0;i < items.Length;i++){
            items[i].SetActive(false);
        }
    }

    void Update() {
        if(clickedInformation){
            leftCharacterButton.SetActive(true);
            rightCharacterButton.SetActive(true);
            clickedBack.SetActive(true);
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

    public void changeAngleInformation(){
        if(clickedInformation == false){
            mainCamera.SetActive(true);
            clickedInformation = true;
        }
    }

    public void nextCharacter(){
        if(mainCamera.transform.position.x < 677){
            mainCamera.transform.position += new Vector3(289, 0, 0);
        }
    }

    public void previousCharacter(){
        if(mainCamera.transform.position.x > -750){
            mainCamera.transform.position += new Vector3(-289, 0, 0);
        }
    }

    public void centreCamera(){
        clickedInformation = false;
        leftCharacterButton.SetActive(false);
        rightCharacterButton.SetActive(false);
        clickedBack.SetActive(false);
        appearMenu();
    }

}
