using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessagePopUp : MonoBehaviour
{

    public GameObject canv;
    private AudioSource audioSource;

    void Start() {
        canv.SetActive(false);
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider player){
        if(player.gameObject.tag == "Player"){
            canv.SetActive(true);
            audioSource.Play();
        }
    }

    void OnTriggerExit(Collider player) {
        if(player.gameObject.tag == "Player"){
            canv.SetActive(false);
        }
    }
}
