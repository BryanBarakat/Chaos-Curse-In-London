using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmMovement : MonoBehaviour
{

    private int rotationSpeed = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Mouse1))
        {
            transform.Rotate (0, 0, 1 * Time.deltaTime * rotationSpeed, Space.World);
        }
            
        else
        {
            transform.Rotate (0, 0, -1 * Time.deltaTime * rotationSpeed, Space.World);
        }
    }
}
