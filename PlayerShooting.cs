using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerShooting : MonoBehaviour
{

    private Animator animator;
    public float damage = 20f;
    // private int counter = 0;
    // public TextMeshProUGUI numKills;
    

    // Start is called before the first frame update
    void Awake()
    {
        // numKills = GetComponent<TextMeshProUGUI>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        PistolShot();
    }

    void PistolShot(){
        if(Input.GetMouseButtonDown(0)){
            animator.SetTrigger("isShooting");
            HitTarget();
        }
    }

    void HitTarget(){
        RaycastHit hit;
        if(Physics.Raycast(Camera.main.transform.position,Camera.main.transform.forward,out hit)){
            if(hit.transform.tag == "Enemy"){
                hit.transform.GetComponent<HealthScript>().ApplyDamage(damage);
                // counter++;
                // numKills.text = counter.ToString();
            }
        }
    }

}
