using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class LegoFollowers : MonoBehaviour
{

    //attributes
    [SerializeField]
    private Animator[] animation;
    NavMeshAgent nav;
    public float walkSpeed = 0.5f;
    public float patrolRadiusMin = 3f, patrolRadiusMax = 8f;
    public float patrolForThisTime = 5f;
    private float patrolTimer = 0f;

    void Awake(){
        nav = GetComponent<NavMeshAgent>();
        for(int i = 0;i < animation.Length;i++){
            animation[i].SetBool("isMoving",true);
        }
    }

    void Start() {
        patrolTimer = patrolForThisTime;
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    public void setNewRandomDest(){
        float randRadius = Random.Range(patrolRadiusMin,patrolRadiusMax);

        Vector3 randDir = Random.insideUnitSphere * randRadius;
        randDir += transform.position;

        NavMeshHit navHit;
        NavMesh.SamplePosition(randDir,out navHit,randRadius,-1);
        navHit.position = new Vector3(navHit.position.z,navHit.position.y,navHit.position.x);
        nav.SetDestination(navHit.position);
    }

    void MovePlayer(){
        nav.isStopped = false;
        nav.speed = walkSpeed;

        patrolTimer += Time.deltaTime;

        if(patrolTimer > patrolForThisTime){
            setNewRandomDest();
            patrolTimer = 0f;
        }
    }

}
