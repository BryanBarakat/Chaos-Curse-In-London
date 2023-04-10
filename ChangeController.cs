using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeController : MonoBehaviour
{

    [SerializeField]
    private GameObject person;
    [SerializeField]
    private GameObject car;
    [SerializeField]
    private GameObject cameras;
    [SerializeField]
    private GameObject mainCamera;
    [SerializeField]
    private GameObject backButton;
    [SerializeField]
    private GameObject EnterButton;
    [SerializeField]
    private GameObject[] items;

    private void Start() {
        cameras.SetActive(false);
        mainCamera.SetActive(true);
        backButton.SetActive(false);
        EnterButton.SetActive(false);
        car.GetComponent<CarMoves>().enabled = false;
        car.GetComponent<HoverboardMoves>().enabled = false;
    }

    private void Update() {
        EnterButton.SetActive(false);
    }

    public void FromCarToPerson(){
        car.GetComponent<CarMoves>().enabled = false;
        person.GetComponent<LegoMoves>().enabled = true;
        cameras.SetActive(false);
        mainCamera.SetActive(true);
        backButton.SetActive(false);
        EnterButton.SetActive(false);
    }

    public void FromPersonToCar(){
        car.GetComponent<CarMoves>().enabled = true;
        person.GetComponent<LegoMoves>().enabled = false;
        cameras.SetActive(true);
        mainCamera.SetActive(false);
        backButton.SetActive(true);
        EnterButton.SetActive(true);
    }

    public void FromCarToPerson2(){
        car.GetComponent<HoverboardMoves>().enabled = false;
        person.GetComponent<LegoMoves>().enabled = true;
        cameras.SetActive(false);
        mainCamera.SetActive(true);
        backButton.SetActive(false);
        EnterButton.SetActive(false);
    }

    public void FromPersonToCar2(){
        car.GetComponent<HoverboardMoves>().enabled = true;
        person.GetComponent<LegoMoves>().enabled = false;
        cameras.SetActive(true);
        mainCamera.SetActive(false);
        backButton.SetActive(true);
        EnterButton.SetActive(true);
    }

    public void disappearItems(){
        for(int i = 0;i < items.Length;i++){
            items[i].SetActive(false);
        }
    }

    public void appearItems(){
        for(int i = 0;i < items.Length;i++){
            items[i].SetActive(true);
        }
    }
}
