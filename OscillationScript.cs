using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OscillationScript : MonoBehaviour
{

    public float amplitude;
    public float quickness;
    Vector3 pos;

    void Start() {
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(pos.x,Mathf.Sin(Time.time * quickness) * amplitude + pos.y,pos.z);
    }
}
