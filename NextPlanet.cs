using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextPlanet : MonoBehaviour
{
    public void nextPlanet(){
        Camera.main.transform.Rotate(0, 90,0);
    }
}
