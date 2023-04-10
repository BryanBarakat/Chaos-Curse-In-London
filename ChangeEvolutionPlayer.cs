using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeEvolutionPlayer : MonoBehaviour
{

    [SerializeField]
    private GameObject[] items;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < items.Length;i++){
            items[i].SetActive(false);
        }
    }

    public void changeToBryan(){
        items[0].SetActive(true);
        items[1].SetActive(false);
        items[2].SetActive(false);
    }

    public void changeToValerie(){
        items[0].SetActive(false);
        items[1].SetActive(true);
        items[2].SetActive(false);
    }

    public void changeToKaia(){
        items[0].SetActive(false);
        items[1].SetActive(false);
        items[2].SetActive(true);
    }

}
