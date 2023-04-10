using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponScript : MonoBehaviour
{
    private Animator animation;

    public GameObject attackPoint;

    void Awake(){
        animation = GetComponent<Animator>();
    }

    void Aim(bool canAim){
        animation.SetBool("Aim", canAim);
    }

    void turnOnAttackPoint(){
        attackPoint.SetActive(true);
    }

    void turnOffAttackPoint(){
        if(attackPoint.activeInHierarchy){
            attackPoint.SetActive(false);
        }
    }

}
