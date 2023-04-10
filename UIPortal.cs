using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIPortal : MonoBehaviour
{

    Camera cam;
    bool clickedPortal = false;

    [SerializeField]
    private GameObject enterButton;
    [SerializeField]
    private GameObject clickedBack;
    [SerializeField]
    private GameObject[] listOfMenuItems;
    [SerializeField]
    private GameObject[] cameras;
    [SerializeField]
    private GameObject mainCamera;

    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
        enterButton.SetActive(false);
        mainCamera.SetActive(false);
        clickedBack.SetActive(false);
    }

    void Update() {
        if(clickedPortal){
            enterButton.SetActive(true);
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

    public void changeAnglePortal(){
        if(clickedPortal == false){
            mainCamera.SetActive(true);
            clickedPortal = true;
        }
    }

    public void centreCamera(){
        clickedPortal = false;
        enterButton.SetActive(false);
        clickedBack.SetActive(false);
        appearMenu();
    }

    public void teleport(){
        SceneManager.LoadScene("MainPlayGroundScene");
    }

}
