using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFootsteps : MonoBehaviour
{

    [SerializeField]
    private AudioClip[] audioClip;

    [SerializeField]
    private AudioClip[] audioClip2;

    private AudioSource audioSource;
    private AudioSource audioSource2;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource2 = GetComponent<AudioSource>();    
    }

    private void Step(){
        AudioClip clip = fetchRandomClip();
        audioSource2.Stop();
        audioSource.PlayOneShot(clip);
    }

    public void Jump(){
        AudioClip clip = audioClip[audioClip.Length-1];
        audioSource2.Stop();
        audioSource.PlayOneShot(clip);
    }

    public void Dance(){
        AudioClip clip = audioClip2[0];
        audioSource2.PlayOneShot(clip);
    }

    public void Shot(){
        AudioClip clip = audioClip2[1];
        audioSource2.PlayOneShot(clip);
    }

    public void Dying(){
        AudioClip clip = audioClip2[1];
        audioSource2.PlayOneShot(clip);
    }

    public void Punch(){
        AudioClip clip = audioClip2[2];
        audioSource2.PlayOneShot(clip);
    }

    private AudioClip fetchRandomClip(){
        int ind = Random.Range(0,audioClip.Length - 2);
        return audioClip[ind];
    }


}
