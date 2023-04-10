using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPOV : MonoBehaviour
{

    //attributes
    private CharacterController character_Controller;
    private Vector3 move_Direction;
    public float speed = 5f;
    private float gravity = 20f;
    public float jump_Force = 10f;
    private float vertical_Velocity;
    private Animator animation;
    private PlayerFootsteps pf;

    void Awake(){
        character_Controller = GetComponent<CharacterController>();
        pf = GetComponent<PlayerFootsteps>();
    }

    // Start is called before the first frame update
    void Start()
    {
        animation = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveThePlayer();
    }

    void MoveThePlayer(){
        move_Direction = new Vector3(Input.GetAxis("Horizontal"),0f,Input.GetAxis("Vertical"));
        move_Direction = transform.TransformDirection(move_Direction);
        move_Direction *= speed * Time.deltaTime;

        if(move_Direction != Vector3.zero){
            if(Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A)){
                animation.SetBool("isDiagonalLeft",true);
                animation.SetBool("isDiagonalRight",false);
                animation.SetBool("isHooking",false);
                animation.SetBool("isUppercuting",false);
                animation.SetBool("isJabbing",false);
                animation.SetBool("isKicking",false);
                animation.SetBool("isRunningBackwards",false);
                animation.SetBool("isAiming",false);
            }
            else if(Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D)){
                animation.SetBool("isDiagonalRight",true);
                animation.SetBool("isDiagonalLeft",false);
                animation.SetBool("isHooking",false);
                animation.SetBool("isUppercuting",false);
                animation.SetBool("isJabbing",false);
                animation.SetBool("isKicking",false);
                animation.SetBool("isRunningBackwards",false);
                animation.SetBool("isAiming",false);
            }
            else if(Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.LeftShift)){
                speed = 7f;
                animation.SetBool("isAiming",false);
                animation.SetBool("isHooking",false);
                animation.SetBool("isUppercuting",false);
                animation.SetBool("isJabbing",false);
                animation.SetBool("isKicking",false);
                animation.SetBool("isDiagonalRight",false);
                animation.SetBool("isDiagonalLeft",false);
                animation.SetBool("isMoving",false);
                animation.SetBool("isStrafingRight",false);
                animation.SetBool("isStrafingLeft",false);
                animation.SetBool("isRunningBackwards",true);
                animation.SetBool("isDancing",false);
                
            }
            else if(Input.GetKey(KeyCode.S)){
                speed = 6f;
                animation.SetBool("isAiming",false);
                animation.SetBool("isHooking",false);
                animation.SetBool("isUppercuting",false);
                animation.SetBool("isJabbing",false);
                animation.SetBool("isKicking",false);
                animation.SetBool("isDiagonalRight",false);
                animation.SetBool("isDiagonalLeft",false);
                animation.SetBool("isMoving",false);
                animation.SetBool("isStrafingRight",false);
                animation.SetBool("isStrafingLeft",false);
                animation.SetBool("isWalkingBackwards",true);
                animation.SetBool("isDancing",false);
                animation.SetBool("isRunningBackwards",false);
            }
            else if(Input.GetKey(KeyCode.A)){
                speed = 4f;
                animation.SetBool("isAiming",false);
                animation.SetBool("isHooking",false);
                animation.SetBool("isUppercuting",false);
                animation.SetBool("isJabbing",false);
                animation.SetBool("isKicking",false);
                animation.SetBool("isDiagonalRight",false);
                animation.SetBool("isStrafingLeft",true);
                animation.SetBool("isDiagonalLeft",false);
                animation.SetBool("isWalkingBackwards",false);
                animation.SetBool("isMoving",false);
                animation.SetBool("isStrafingRight",false);
                animation.SetBool("isDancing",false);
                animation.SetBool("isRunningBackwards",false);
            }
            else if(Input.GetKey(KeyCode.D)){
                speed = 4f;
                animation.SetBool("isAiming",false);
                animation.SetBool("isHooking",false);
                animation.SetBool("isUppercuting",false);
                animation.SetBool("isJabbing",false);
                animation.SetBool("isKicking",false);
                animation.SetBool("isDiagonalRight",false);
                animation.SetBool("isStrafingRight",true);
                animation.SetBool("isDiagonalLeft",false);
                animation.SetBool("isWalkingBackwards",false);
                animation.SetBool("isMoving",false);
                animation.SetBool("isStrafingLeft",false);
                animation.SetBool("isDancing",false);
                animation.SetBool("isRunningBackwards",false);
            }
            else if(Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift)){
                speed = 7f;
                animation.SetBool("isAiming",false);
                animation.SetBool("isHooking",false);
                animation.SetBool("isUppercuting",false);
                animation.SetBool("isJabbing",false);
                animation.SetBool("isKicking",false);
                animation.SetBool("isDiagonalRight",false);
                animation.SetBool("isWalkingBackwards",false);
                animation.SetBool("isMoving",true);
                animation.SetBool("isDiagonalLeft",false);
                animation.SetBool("isStrafingRight",false);
                animation.SetBool("isStrafingLeft",false);
                animation.SetBool("isDancing",false);
                animation.SetBool("isRunningBackwards",false);
            }
            else if(Input.GetKey(KeyCode.W)){
                speed = 6f;
                animation.SetBool("isAiming",false);
                animation.SetBool("isHooking",false);
                animation.SetBool("isUppercuting",false);
                animation.SetBool("isJabbing",false);
                animation.SetBool("isKicking",false);
                animation.SetBool("isDiagonalRight",false);
                animation.SetBool("isWalkingBackwards",false);
                animation.SetBool("isMoving",true);
                animation.SetBool("isDiagonalLeft",false);
                animation.SetBool("isStrafingRight",false);
                animation.SetBool("isStrafingLeft",false);
                animation.SetBool("isDancing",false);
                animation.SetBool("isRunningBackwards",false);
            }
            if(Input.GetKey(KeyCode.Q)){
                animation.SetBool("isAiming",false);
                animation.SetBool("isKicking",true);
                animation.SetBool("isHooking",false);
                animation.SetBool("isUppercuting",false);
                animation.SetBool("isJabbing",false);
                animation.SetBool("isDiagonalRight",false);
                animation.SetBool("isWalkingBackwards",false);
                animation.SetBool("isDiagonalLeft",false);
                animation.SetBool("isStrafingRight",false);
                animation.SetBool("isStrafingLeft",false);
                animation.SetBool("isDancing",false);
                animation.SetBool("isRunningBackwards",false);
            }
            if(Input.GetKey(KeyCode.R)){
                animation.SetBool("isAiming",false);
                animation.SetBool("isUppercuting",true);
                animation.SetBool("isJabbing",false);
                animation.SetBool("isKicking",false);
                animation.SetBool("isHooking",false);
                animation.SetBool("isDiagonalRight",false);
                animation.SetBool("isWalkingBackwards",false);
                animation.SetBool("isDiagonalLeft",false);
                animation.SetBool("isStrafingRight",false);
                animation.SetBool("isStrafingLeft",false);
                animation.SetBool("isDancing",false);
                animation.SetBool("isRunningBackwards",false);
            }
            if(Input.GetKey(KeyCode.F)){
                animation.SetBool("isAiming",false);
                animation.SetBool("isJabbing",true);
                animation.SetBool("isKicking",false);
                animation.SetBool("isUppercuting",false);
                animation.SetBool("isHooking",false);
                animation.SetBool("isDiagonalRight",false);
                animation.SetBool("isWalkingBackwards",false);
                animation.SetBool("isDiagonalLeft",false);
                animation.SetBool("isStrafingRight",false);
                animation.SetBool("isStrafingLeft",false);
                animation.SetBool("isDancing",false);
                animation.SetBool("isRunningBackwards",false);
            }
            if(Input.GetKey(KeyCode.C)){
                animation.SetBool("isAiming",false);
                animation.SetBool("isHooking",true);
                animation.SetBool("isUppercuting",false);
                animation.SetBool("isJabbing",false);
                animation.SetBool("isKicking",false);
                animation.SetBool("isDiagonalRight",false);
                animation.SetBool("isWalkingBackwards",false);
                animation.SetBool("isDiagonalLeft",false);
                animation.SetBool("isStrafingRight",false);
                animation.SetBool("isStrafingLeft",false);
                animation.SetBool("isDancing",false);
                animation.SetBool("isRunningBackwards",false);
            }
        }
        else{
                if(Input.GetKey(KeyCode.E)){
                    animation.SetBool("isAiming",true);
                }
                if(Input.GetKey(KeyCode.G)){
                    animation.SetBool("isAiming",false);
                    animation.SetBool("isDancing",true);
                    animation.SetBool("isDiagonalRight",false);
                    animation.SetBool("isDiagonalLeft",false);
                }
                if(Input.GetKey(KeyCode.Q)){
                    animation.SetBool("isAiming",false);
                    animation.SetBool("isKicking",true);
                    animation.SetBool("isHooking",false);
                    animation.SetBool("isUppercuting",false);
                    animation.SetBool("isJabbing",false);
                    animation.SetBool("isDiagonalRight",false);
                    animation.SetBool("isRunningBackwards",false);
                    animation.SetBool("isWalkingBackwards",false);
                    animation.SetBool("isDiagonalLeft",false);
                    animation.SetBool("isStrafingRight",false);
                    animation.SetBool("isStrafingLeft",false);
                    animation.SetBool("isDancing",false);
                }
                if(Input.GetKey(KeyCode.R)){
                    animation.SetBool("isAiming",false);
                    animation.SetBool("isUppercuting",true);
                    animation.SetBool("isJabbing",false);
                    animation.SetBool("isKicking",false);
                    animation.SetBool("isHooking",false);
                    animation.SetBool("isDiagonalRight",false);
                    animation.SetBool("isWalkingBackwards",false);
                    animation.SetBool("isDiagonalLeft",false);
                    animation.SetBool("isStrafingRight",false);
                    animation.SetBool("isStrafingLeft",false);
                    animation.SetBool("isDancing",false);
                    animation.SetBool("isRunningBackwards",false);
                }
                if(Input.GetKey(KeyCode.F)){
                    animation.SetBool("isAiming",false);
                    animation.SetBool("isJabbing",true);
                    animation.SetBool("isKicking",false);
                    animation.SetBool("isUppercuting",false);
                    animation.SetBool("isHooking",false);
                    animation.SetBool("isDiagonalRight",false);
                    animation.SetBool("isWalkingBackwards",false);
                    animation.SetBool("isDiagonalLeft",false);
                    animation.SetBool("isStrafingRight",false);
                    animation.SetBool("isStrafingLeft",false);
                    animation.SetBool("isDancing",false);
                    animation.SetBool("isRunningBackwards",false);
                }
                if(Input.GetKey(KeyCode.C)){
                    animation.SetBool("isAiming",false);
                    animation.SetBool("isHooking",true);
                    animation.SetBool("isUppercuting",false);
                    animation.SetBool("isJabbing",false);
                    animation.SetBool("isKicking",false);
                    animation.SetBool("isDiagonalRight",false);
                    animation.SetBool("isWalkingBackwards",false);
                    animation.SetBool("isDiagonalLeft",false);
                    animation.SetBool("isStrafingRight",false);
                    animation.SetBool("isStrafingLeft",false);
                    animation.SetBool("isDancing",false);
                    animation.SetBool("isRunningBackwards",false);
                }
                else{
                    animation.SetBool("isWalkingBackwards",false);
                    animation.SetBool("isDiagonalRight",false);
                    animation.SetBool("isDiagonalLeft",false);
                    animation.SetBool("isMoving",false);
                    animation.SetBool("isStrafingRight",false);
                    animation.SetBool("isStrafingLeft",false);
                    animation.SetBool("isRunningBackwards",false);
                }
        }

        ApplyGravity();

        character_Controller.Move(move_Direction);
    }

    void ApplyGravity(){
        if(character_Controller.isGrounded){
            vertical_Velocity -= gravity * Time.deltaTime;
            PlayerJump();
        }
        else{
            vertical_Velocity -= gravity * Time.deltaTime;
        }
        move_Direction.y = vertical_Velocity * Time.deltaTime;
    }

    void PlayerJump(){
        if(character_Controller.isGrounded && Input.GetKeyDown(KeyCode.Space)){
            vertical_Velocity = jump_Force;
            animation.SetBool("isJumping",true);
        }
        else{
            animation.SetBool("isJumping",false);
        }
    }

}
