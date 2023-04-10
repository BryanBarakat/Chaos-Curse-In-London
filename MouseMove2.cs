// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class MouseMove2 : MonoBehaviour
// {
//     [SerializeField]
//     private Transform pRoot,lookedFrom;

//     [SerializeField]
//     private float sensi = 5f;

//     [SerializeField]
//     private Vector2 defaultLookLimits = new Vector2(0f,0f);

//     private Vector2 lookAngles;

//     private Vector2 currentMouseLook;


//       // Start is called before the first frame update
//     void Start()
//     {
//         Cursor.lockState = CursorLockMode.Locked;
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         CursorLock();
//         Looking();
//     }

//     void Looking(){

//         currentMouseLook = new Vector2(Input.GetAxis("Mouse Y"),Input.GetAxis("Mouse X"));

//         lookAngles.x += currentMouseLook.x * sensi * -1f;
//         lookAngles.y += currentMouseLook.y * sensi;

//         lookAngles.x = Mathf.Clamp(lookAngles.x,defaultLookLimits.x,defaultLookLimits.y);

//         lookedFrom.localRotation = Quaternion.Euler(lookAngles.x,0f,0f);
//         pRoot.localRotation = Quaternion.Euler(0f,lookAngles.y,0f);

//     }

//     void CursorLock(){
//         if(Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown("l")){
//             if(Cursor.lockState == CursorLockMode.Locked){
//                 Cursor.lockState = CursorLockMode.None;
//             }
//             else{
//                 Cursor.lockState = CursorLockMode.Locked;
//             }
//         }
//     }
// }
