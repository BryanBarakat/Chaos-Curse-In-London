using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterMuseum : MonoBehaviour
{
    [SerializeField]
    private GameObject player;

    private void OnTriggerEnter(Collider other) {
        player.transform.position = new Vector3(-909.9f,0f,90.1f);
    }
}
