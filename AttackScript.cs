using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackScript : MonoBehaviour
{

    public LayerMask layerMask;
    public float damage = 10f;
    public float radius = 1f;

    // Update is called once per frame
    void Update()
    {
        Collider[] collisions = Physics.OverlapSphere(transform.position,radius,layerMask);

        if(collisions.Length > 0){
            print("touched" + collisions[0].gameObject.tag);
            collisions[0].gameObject.GetComponent<HealthScript>().ApplyDamage(damage);
            gameObject.SetActive(false);
        }
    }
}
