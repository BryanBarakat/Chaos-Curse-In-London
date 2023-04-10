using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreviousPlanet : MonoBehaviour
{
    public void previousPlanet(){
        Camera.main.transform.Rotate(0, -90,0);
    }
}
