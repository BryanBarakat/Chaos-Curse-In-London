using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegoMoves : MonoBehaviour
{

    //attributes
    private CharacterController character_Controller;
    private Vector3 move_Direction;
    public float speed = 25f;
    private float gravity = 20f;
    public float jump_Force = 10f;
    private float vertical_Velocity;
    [SerializeField]
    private Animator[] animation;
    [SerializeField]
    private Animator[] animationsJump;
    [SerializeField]
    private GameObject backButton;
    [SerializeField]
    private GameObject EnterButton;
    bool colliding = false;


    void Awake(){
        character_Controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(colliding == false){
            EnterButton.SetActive(false);
        }
        MoveThePlayer();
    }

    void MoveThePlayer(){
        move_Direction = new Vector3(0f,0f,Input.GetAxis("Vertical"));
        move_Direction = transform.TransformDirection(move_Direction);
        move_Direction *= speed * Time.deltaTime;


        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S)){
            for(int i = 0;i < animation.Length;i++){
                animation[i].SetBool("isMoving",true);
            }
        }
        else{
            for(int i = 0;i < animation.Length;i++){
                animation[i].SetBool("isMoving",false);
            }
        }

        character_Controller.Move(move_Direction);
    }

    private void OnTriggerEnter(Collider other) {
        colliding = true;
    }

    private void OnTriggerExit(Collider other) {
        colliding = false;
    }

}
