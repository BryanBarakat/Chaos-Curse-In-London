using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPlanets : MonoBehaviour
{

    public Vector3 rot;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rot * Time.deltaTime);
    }
}
