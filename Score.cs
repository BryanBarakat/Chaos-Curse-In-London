// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using TMPro;
// using UnityEngine.UI;

// public class Score : MonoBehaviour
// {

//     private int counter = 0;
//     public TextMeshProUGUI numKills;
//     private PlayerShooting shot;

//     // Start is called before the first frame update
//     void Start()
//     {
//         numKills = GetComponent<TextMeshProUGUI>();
//         numKills.text = "0";
//         shot = GetComponent<PlayerShooting>();
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         checkShooting();
//     }

//     void checkShooting(){
//         if(shot.BulletFired() == true){
//             counter ++;
//             numKills.text = counter.ToString();
//         }
//     }

// }
