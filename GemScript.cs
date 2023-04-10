using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemScript : MonoBehaviour
{
    private AudioSource audioSource;
    public Vector3 rot;

    void Start(){
        gameObject.SetActive(true);
        audioSource = GetComponent<AudioSource>();
    }

    void Update(){
        transform.Rotate(rot * Time.deltaTime);
    }

    void OnTriggerEnter(Collider player){
        if(player.gameObject.tag == "Player"){
            audioSource.Play();
            gameObject.SetActive(false);
        }
    }
}
