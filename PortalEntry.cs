using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalEntry : MonoBehaviour
{

    [SerializeField]
    private GameObject UIObjectImage1;
    [SerializeField]
    private GameObject UIObjectImage2;

    void Start() {
        UIObjectImage1.SetActive(false);
        UIObjectImage2.SetActive(false);
    }

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Player"){
            UIObjectImage1.SetActive(true);
            UIObjectImage2.SetActive(true);
            SceneManager.LoadScene("MainPlayGroundScene");
        }
    }
}
