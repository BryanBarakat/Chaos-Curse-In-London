using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISounds : MonoBehaviour
{

    [SerializeField]
    private AudioClip[] audioClip;
    [SerializeField]
    private AudioClip SingleAudioClip;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Step(){
        AudioClip clip = SingleAudioClip;
        audioSource.PlayOneShot(clip);
    }

    public void LeftAndRight(){
        AudioClip clip = audioClip[0];
        audioSource.PlayOneShot(clip);
    }

    public void ButtonsClick(){
        AudioClip clip = audioClip[1];
        audioSource.PlayOneShot(clip);
    }

    public void MenuItemClicked(){
        AudioClip clip = audioClip[0];
        audioSource.PlayOneShot(clip);
    }

    public void LeftAndRightMuseum(){
        AudioClip clip = audioClip[1];
        audioSource.PlayOneShot(clip);
    }

    public void BackButton(){
        AudioClip clip = audioClip[2];
        audioSource.PlayOneShot(clip);
    }
}
