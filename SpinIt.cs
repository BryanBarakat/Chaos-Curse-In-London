using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinIt : MonoBehaviour
{
    public Vector3 rot;
    public GameObject[] items;

    public void spinning(){
        for(int i = 0; i < items.Length;i++){
            items[i].transform.Rotate(rot * Time.deltaTime);
        }
    }

}
