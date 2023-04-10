using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMoves : MonoBehaviour
{

    //attributes
    private CharacterController character_Controller;
    private Vector3 move_Direction;
    public float speed = 25f;
    private float vertical_Velocity;
    [SerializeField]
    private Animator[] animation;
    [SerializeField]
    private GameObject objectUI;
    private AudioSource audioSource;


    void Awake(){
        character_Controller = GetComponent<CharacterController>();
        audioSource = GetComponent<AudioSource>();  
        objectUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        MoveThePlayer();
    }

    void MoveThePlayer(){
        objectUI.SetActive(false);
        move_Direction = new Vector3(-Input.GetAxis("Vertical"),0f,0f);
        move_Direction = transform.TransformDirection(move_Direction);
        move_Direction *= speed * Time.deltaTime;


        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S)){
            for(int i = 0;i < animation.Length;i++){
                animation[i].SetBool("isAdvancing",true);
            }
        }
        else{
            for(int i = 0;i < animation.Length;i++){
                animation[i].SetBool("isAdvancing",false);
            }
        }

        character_Controller.Move(move_Direction);
    }

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Player"){
            objectUI.SetActive(true);
        }
    }

    
    public void InCarMusic(){
        audioSource.Play();
    }

    public void StopMusic(){
        audioSource.Stop();
    }

}
