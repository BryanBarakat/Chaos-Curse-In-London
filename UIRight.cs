using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIRight : MonoBehaviour
{

    Camera cam;
    bool clickedProcess = false;

    [SerializeField]
    private GameObject leftCharacterButton;
    [SerializeField]
    private GameObject hand;
    [SerializeField]
    private GameObject laptop;
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
        leftCharacterButton.SetActive(false);
        rightCharacterButton.SetActive(false);
        mainCamera.SetActive(false);
        hand.SetActive(false);
        laptop.SetActive(false);
        clickedBack.SetActive(false);
        for(int i = 0; i < items.Length;i++){
            items[i].SetActive(false);
        }
    }

    void Update() {
        if(clickedProcess){
            leftCharacterButton.SetActive(true);
            rightCharacterButton.SetActive(true);
            hand.SetActive(true);
            laptop.SetActive(true);
            clickedBack.SetActive(true);
            for(int i = 0; i < items.Length;i++){
            items[i].SetActive(true);
            }
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

    public void changeAngle(){
        if(clickedProcess == false){
            mainCamera.SetActive(true);
            clickedProcess = true;
        }
    }

    public void nextSlide(){
        if(mainCamera.transform.position.x < 677){
            mainCamera.transform.position += new Vector3(265, 0, 0);
        }
    }

    public void previousSlide(){
        if(mainCamera.transform.position.x > -637){
            mainCamera.transform.position += new Vector3(-265, 0, 0);
        }
    }

    public void centreCamera(){
        clickedProcess = false;
        hand.SetActive(false);
        laptop.SetActive(false);
        leftCharacterButton.SetActive(false);
        rightCharacterButton.SetActive(false);
        clickedBack.SetActive(false);
        for(int i = 0; i < items.Length;i++){
            items[i].SetActive(false);
        }
        appearMenu();
    }

}
