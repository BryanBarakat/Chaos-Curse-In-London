using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterUIButtons : MonoBehaviour
{
    [SerializeField]
    private GameObject mainCamera;
    [SerializeField]
    private GameObject enemyOne;
    [SerializeField]
    private GameObject enemyTwo;
    [SerializeField]
    private GameObject enemyThree;

    // Start is called before the first frame update
    void Start()
    {
        enemyOne.SetActive(false);
        enemyTwo.SetActive(false);
        enemyThree.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        checkCoordinates();
    }

    public void checkCoordinates(){
            if(mainCamera.transform.position.x == -759.1001f){
                enemyOne.SetActive(true);
                enemyTwo.SetActive(false);
                enemyThree.SetActive(false);
            }
            else if(mainCamera.transform.position.x == -470.1001f){
                enemyOne.SetActive(false);
                enemyTwo.SetActive(true);
                enemyThree.SetActive(false);
            }
            else if(mainCamera.transform.position.x == -181.1001f){
                enemyOne.SetActive(false);
                enemyTwo.SetActive(false);
                enemyThree.SetActive(true);
            }
            else{
                enemyOne.SetActive(false);
                enemyTwo.SetActive(false);
                enemyThree.SetActive(false);
            }
    }

    public void removeActivityUI(){
        enemyOne.SetActive(false);
        enemyTwo.SetActive(false);
        enemyThree.SetActive(false);
    }

}
