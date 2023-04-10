using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyClone : MonoBehaviour {

    public static EnemyClone instance;

    public GameObject parasitePrefab, clownPrefab, zombiePrefab;

    public Transform[] clownPoints, parasitePoints,zombiePoints;

    public int clownCount, parasiteCount,zombieCount;

    private int initialClownCount, initialParasiteCount,initialZombieCount;

    public float timeBeforeSpawn = 10f;

    void Awake () {
        Instantiation();
	}

    void Start() {
        initialClownCount = clownCount;
        initialParasiteCount = parasiteCount ;
        initialZombieCount = zombieCount;

        SpawnEnemiesNow();

        StartCoroutine("SpawnEnemies");
    }

    void Instantiation() {
        if(instance == null) {
            instance = this;
        }
    }

    void SpawnEnemiesNow() {
        SpawnClowns();
        SpawnZombies();
        SpawnParasites();
    }

    void SpawnClowns() {

        int index = 0;

        for (int i = 0; i < clownCount; i++) {

            if (index >= clownPoints.Length) {
                index = 0;
            }

            Instantiate(clownPrefab, clownPoints[index].position, Quaternion.identity);

            index++;

        }

        clownCount = 0;

    }

    void SpawnZombies() {

        int index = 0;

        for (int i = 0; i < zombieCount; i++) {

            if (index >= zombiePoints.Length)
            {
                index = 0;
            }

            Instantiate(zombiePrefab, zombiePoints[index].position, Quaternion.identity);

            index++;

        }

        zombieCount = 0;

    }

    void SpawnParasites() {

        int index = 0;

        for (int i = 0; i < parasiteCount; i++) {

            if (index >= parasitePoints.Length)
            {
                index = 0;
            }

            Instantiate(parasitePrefab, parasitePoints[index].position, Quaternion.identity);

            index++;

        }

        parasiteCount = 0;

    }

    IEnumerator SpawnEnemies() {
        yield return new WaitForSeconds(timeBeforeSpawn);

        SpawnClowns();
        SpawnParasites();
        SpawnZombies();
        StartCoroutine("SpawnEnemies");

    }

    public void EnemyDied(int num) {

        if(num == 1) {

            parasiteCount++;

            if(parasiteCount > initialParasiteCount) {
                parasiteCount = initialParasiteCount;
            }

        } else if(num == 2) {

            clownCount++;

            if(clownCount > initialClownCount) {
                clownCount = initialClownCount;
            }

        }
        else if(num == 3) {

            zombieCount++;

            if(zombieCount > initialZombieCount) {
                zombieCount = initialZombieCount;
            }

        }

    }

    public void StopSpawning() {
        StopCoroutine("SpawnEnemies");
    }

}