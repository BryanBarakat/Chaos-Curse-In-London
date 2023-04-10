using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateEnemies : MonoBehaviour
{

    [SerializeField]
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void Run(){
        anim.SetBool("isRunning",true);
        anim.SetBool("isWalking",false);
        anim.SetBool("isPunching",false);
        anim.SetBool("isIdle",false);
    }

    public void Walk(){
        anim.SetBool("isRunning",false);
        anim.SetBool("isWalking",true);
        anim.SetBool("isPunching",false);
        anim.SetBool("isIdle",false);
    }

    public void Punch(){
        anim.SetBool("isRunning",false);
        anim.SetBool("isWalking",false);
        anim.SetBool("isPunching",true);
        anim.SetBool("isIdle",false);
    }

    public void Idle(){
        anim.SetBool("isRunning",false);
        anim.SetBool("isWalking",false);
        anim.SetBool("isPunching",false);
        anim.SetBool("isIdle",true);
    }

}
