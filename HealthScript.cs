using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.AI;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour
{

    private EnemyAnimations enemyAnimator;
    private NavMeshAgent navAgent;
    private EnemyController enemyController;

    public float health = 100f;
    public bool isPlayer,isClown,isParasite,isZombie;
    private bool isDead;
    private PlayerStats pStats;

    // Start is called before the first frame update
    void Awake()
    {
        if(isClown || isParasite || isZombie){
            enemyAnimator = GetComponent<EnemyAnimations>();
            enemyController = GetComponent<EnemyController>();
            navAgent = GetComponent<NavMeshAgent>();
        }
        if(isPlayer){
            pStats = GetComponent<PlayerStats>();
        }
    }

    public void ApplyDamage(float damage){
        if(isDead){
            return;
        }

        health -= damage;

        if(isPlayer){
            pStats.HealthStats(health);
        }

        if(isClown || isParasite || isZombie){
            if(enemyController.EnemyState == EnemyState.PATROL){
                enemyController.chaseDistance = 50f;
            }
        }

        if(health <= 0){
            PlayerDead();
            isDead = true;
        }

    }

    void PlayerDead(){
        if(isClown || isParasite || isZombie){
            navAgent.velocity = Vector3.zero;
            navAgent.isStopped = true;
            enemyController.enabled = false;

            enemyAnimator.Dead();

            // StartCoroutine()
            if(isParasite){
                EnemyClone.instance.EnemyDied(1);
            }
            else if(isClown){
                EnemyClone.instance.EnemyDied(2);
            }
            else if(isZombie){
                EnemyClone.instance.EnemyDied(3);
            }
            
        }

        if(isPlayer){
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");

            for(int i = 0;i < enemies.Length;i++){
                enemies[i].GetComponent<EnemyController>().enabled = false;
            }

            // EnemyClone.instance.StopSpawning();

            GetComponent<PlayerPOV>().enabled = false;
            GetComponent<PlayerShooting>().enabled = false;
        }

        if(tag == "Player"){
            Invoke("RestartGame",2f);
        }
        else{
            Invoke("TurnOffGameObject",2f);
        }

    }

    void RestartGame(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
    }

    void TurnOffGameObject(){
        gameObject.SetActive(false);
    }

}
