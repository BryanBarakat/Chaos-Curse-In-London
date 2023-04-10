using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIClothing : MonoBehaviour
{

    Camera cam;
    bool clickedClothing = false;
    bool clickedHead = false;
    bool clickedBody = false;
    bool clickedArms = false;
    bool clickedLegs = false;

    bool clickedRed = false;
    bool clickedBlue = false;
    bool clickedGold = false;
    bool clickedGrey = false;
    bool clickedPurple = false;
    bool clickedBlack = false;

    [SerializeField]
    private GameObject clickedBack;
    [SerializeField]
    private GameObject[] listOfMenuItems;
    [SerializeField]
    private GameObject[] cameras;
    [SerializeField]
    private GameObject mainCamera;
    [SerializeField]
    private GameObject[] listOfMenuItemsClothing;
    [SerializeField]
    private Material[] listOfMaterials;
    [SerializeField]
    private GameObject[] listOfParts;
    [SerializeField]
    private GameObject[] backgroundItems;

    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
        mainCamera.SetActive(false);
        clickedBack.SetActive(false);
        for(int f = 0;f < backgroundItems.Length;f++){
            backgroundItems[f].SetActive(false);
        }
        for(int k = 0;k < listOfMenuItemsClothing.Length;k++){
            listOfMenuItemsClothing[k].SetActive(false);
        }
    }

    void Update() {
        if(clickedClothing){
            clickedBack.SetActive(true);
            disappearMenu();
        }
    }

    public void disappearMenu(){
        for(int i = 0;i < listOfMenuItems.Length;i++){
            listOfMenuItems[i].SetActive(false);
        }
        for(int j = 0;j < cameras.Length;j++){
            cameras[j].SetActive(false);
            cameras[j].GetComponent<MouseMovement>().enabled = false;
        }
        for(int k = 0;k < listOfMenuItemsClothing.Length;k++){
            listOfMenuItemsClothing[k].SetActive(true);
        }
        for(int f = 0;f < backgroundItems.Length;f++){
            backgroundItems[f].SetActive(true);
        }
    }

    public void appearMenu(){
        for(int k = 0;k < listOfMenuItems.Length;k++){
            listOfMenuItems[k].SetActive(true);
        }
        for(int i = 0;i < cameras.Length;i++){
            cameras[i].SetActive(true);
            cameras[i].GetComponent<MouseMovement>().enabled = true;
        }
        for(int x = 0;x < listOfMenuItemsClothing.Length;x++){
            listOfMenuItemsClothing[x].SetActive(false);
        }
        mainCamera.SetActive(false);
        for(int f = 0;f < backgroundItems.Length;f++){
            backgroundItems[f].SetActive(false);
        }
    }

    public void changeAngleClothing(){
        if(clickedClothing == false){
            mainCamera.SetActive(true);
            clickedClothing = true;
        }
    }

    public void centreCamera(){
        clickedClothing = false;
        clickedBack.SetActive(false);
        appearMenu();
    }

    public void HeadClicked(){
        clickedHead = true;
        clickedBody = false;
        clickedLegs = false;
        clickedArms = false;
        listOfMenuItemsClothing[0].SetActive(false);
        listOfMenuItemsClothing[1].SetActive(true);
        listOfMenuItemsClothing[2].SetActive(true);
        listOfMenuItemsClothing[3].SetActive(true);
    }

    public void BodyClicked(){
        clickedBody = true;
        clickedHead = false;
        clickedLegs = false;
        clickedArms = false;
        listOfMenuItemsClothing[0].SetActive(true);
        listOfMenuItemsClothing[1].SetActive(false);
        listOfMenuItemsClothing[2].SetActive(true);
        listOfMenuItemsClothing[3].SetActive(true);
    }

    public void ArmsClicked(){
        clickedArms = true;
        clickedHead = false;
        clickedBody = false;
        clickedLegs = false;
        listOfMenuItemsClothing[0].SetActive(true);
        listOfMenuItemsClothing[1].SetActive(true);
        listOfMenuItemsClothing[2].SetActive(false);
        listOfMenuItemsClothing[3].SetActive(true);
    }

    public void LegsClicked(){
        clickedLegs = true;
        clickedHead = false;
        clickedBody = false;
        clickedArms = false;
        listOfMenuItemsClothing[0].SetActive(true);
        listOfMenuItemsClothing[1].SetActive(true);
        listOfMenuItemsClothing[2].SetActive(true);
        listOfMenuItemsClothing[3].SetActive(false);
    }

    public void RedClicked(){
        clickedRed = true;
        clickedBlue = false;
        clickedGold = false;
        clickedGrey = false;
        clickedPurple = false;
        clickedBlack = false;
        applyColors();
    }

    public void BlueClicked(){
        clickedRed = false;
        clickedBlue = true;
        clickedGold = false;
        clickedGrey = false;
        clickedPurple = false;
        clickedBlack = false;
        applyColors();
    }

    public void GoldClicked(){
        clickedRed = false;
        clickedBlue = false;
        clickedGold = true;
        clickedGrey = false;
        clickedPurple = false;
        clickedBlack = false;
        applyColors();
    }

    public void GreyClicked(){
        clickedRed = false;
        clickedBlue = false;
        clickedGold = false;
        clickedGrey = true;
        clickedPurple = false;
        clickedBlack = false;
        applyColors();
    }

    public void PurpleClicked(){
        clickedRed = false;
        clickedBlue = false;
        clickedGold = false;
        clickedGrey = false;
        clickedPurple = true;
        clickedBlack = false;
        applyColors();
    }

    public void BlackClicked(){
        clickedRed = false;
        clickedBlue = false;
        clickedGold = false;
        clickedGrey = false;
        clickedPurple = false;
        clickedBlack = true;
        applyColors();
    }

    public void applyColors(){
        if(clickedHead){
            if(clickedRed){
                listOfParts[0].GetComponent<MeshRenderer>().material = listOfMaterials[0];
            }
            if(clickedBlue){
                listOfParts[0].GetComponent<MeshRenderer>().material = listOfMaterials[1];
            }
            if(clickedGold){
                listOfParts[0].GetComponent<MeshRenderer>().material = listOfMaterials[2];
            }
            if(clickedGrey){
                listOfParts[0].GetComponent<MeshRenderer>().material = listOfMaterials[3];
            }
            if(clickedPurple){
                listOfParts[0].GetComponent<MeshRenderer>().material = listOfMaterials[4];
            }
            if(clickedBlack){
                listOfParts[0].GetComponent<MeshRenderer>().material = listOfMaterials[5];
            }
        }
        else if(clickedBody){
            if(clickedRed){
                listOfParts[1].GetComponent<MeshRenderer>().material = listOfMaterials[0];
            }
            if(clickedBlue){
                listOfParts[1].GetComponent<MeshRenderer>().material = listOfMaterials[1];
            }
            if(clickedGold){
                listOfParts[1].GetComponent<MeshRenderer>().material = listOfMaterials[2];
            }
            if(clickedGrey){
                listOfParts[1].GetComponent<MeshRenderer>().material = listOfMaterials[3];
            }
            if(clickedPurple){
                listOfParts[1].GetComponent<MeshRenderer>().material = listOfMaterials[4];
            }
            if(clickedBlack){
                listOfParts[1].GetComponent<MeshRenderer>().material = listOfMaterials[5];
            }
        }
        else if(clickedLegs){
            if(clickedRed){
                listOfParts[2].GetComponent<MeshRenderer>().material = listOfMaterials[0];
            }
            if(clickedBlue){
                listOfParts[2].GetComponent<MeshRenderer>().material = listOfMaterials[1];
            }
            if(clickedGold){
                listOfParts[2].GetComponent<MeshRenderer>().material = listOfMaterials[2];
            }
            if(clickedGrey){
                listOfParts[2].GetComponent<MeshRenderer>().material = listOfMaterials[3];
            }
            if(clickedPurple){
                listOfParts[2].GetComponent<MeshRenderer>().material = listOfMaterials[4];
            }
            if(clickedBlack){
                listOfParts[2].GetComponent<MeshRenderer>().material = listOfMaterials[5];
            }
        }
        else if(clickedArms){
            if(clickedRed){
                listOfParts[3].GetComponent<MeshRenderer>().material = listOfMaterials[0];
                listOfParts[4].GetComponent<MeshRenderer>().material = listOfMaterials[0];
            }
            if(clickedBlue){
                listOfParts[3].GetComponent<MeshRenderer>().material = listOfMaterials[1];
                listOfParts[4].GetComponent<MeshRenderer>().material = listOfMaterials[1];
            }
            if(clickedGold){
                listOfParts[3].GetComponent<MeshRenderer>().material = listOfMaterials[2];
                listOfParts[4].GetComponent<MeshRenderer>().material = listOfMaterials[2];
            }
            if(clickedGrey){
                listOfParts[3].GetComponent<MeshRenderer>().material = listOfMaterials[3];
                listOfParts[4].GetComponent<MeshRenderer>().material = listOfMaterials[3];
            }
            if(clickedPurple){
                listOfParts[3].GetComponent<MeshRenderer>().material = listOfMaterials[4];
                listOfParts[4].GetComponent<MeshRenderer>().material = listOfMaterials[4];
            }
            if(clickedBlack){
                listOfParts[3].GetComponent<MeshRenderer>().material = listOfMaterials[5];
                listOfParts[4].GetComponent<MeshRenderer>().material = listOfMaterials[5];
            }
        }
    }

}
