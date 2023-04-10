using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxBomb : MonoBehaviour
{

    public MeshRenderer box;
    public BoxCollider boxCollider;

    public GameObject brokenBox;

    public AudioSource clipBreak;

    private void OnTriggerEnter(Collider player)
    {
        if(player.gameObject.tag == "Player"){

        box.enabled = false;
        boxCollider.enabled = false;
        brokenBox.SetActive(true);
        clipBreak.Play();
        
        }
    }
}