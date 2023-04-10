using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public Image health;

    public void HealthStats(float healthVal){
        healthVal /= 100f;
        health.fillAmount = healthVal;
    }
}
