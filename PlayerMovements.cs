using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{

    private AudioSource movementSound;

    [SerializeField]
    private AudioClip[] movementClip;

    private CharacterController CC;

    [HideInInspector]
    public float volumeMin,volumeMax;

    private float accumulatedDistance;

    [HideInInspector]
    public float stepDistance;

    // Start is called before the first frame update
    void Awake()
    {
        movementSound = GetComponent<AudioSource>();
        CC = GetComponentInParent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckStepSound();
    }

    void CheckStepSound(){
        if(!CC.isGrounded){
            return;
        }

        if(CC.velocity.sqrMagnitude > 0){
            accumulatedDistance += Time.deltaTime;
            if(accumulatedDistance > stepDistance){
                movementSound.volume = Random.Range(volumeMin,volumeMax);
                movementSound.clip = movementClip[Random.Range(0,movementClip.Length)];
                movementSound.Play();

                accumulatedDistance = 0f;
            }
        }
        else{
            accumulatedDistance = 0f;
        }
    }

}
