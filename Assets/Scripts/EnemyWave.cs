using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWave : MonoBehaviour
{
    int startWave = 1;
    public GameObject Enemy;
    public Vector2 Spawn;
    private float timeOut;
    int AmountOfEnemy = 0;
    public static int countDead;

    public float waveDelay = 2.0f;
    public float waveFrequency = 0.5f;
    public float waveEnd = 4.0f;
    // Start is called before the first frame update
    void Start()
    {
        Spawn = new Vector2(-7,0);
    }

    public void CheckWaveIsAlive(){
        if(countDead >= AmountOfEnemy && countDead != 0){
            //Debug.Log("Проверяю");
            countDead = 0;
            AmountOfEnemy = 0;
            startWave = 1;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(startWave == 1){
            startWave = 0;
            InvokeRepeating("CreateWave", waveDelay, waveFrequency);
            Invoke("CancelInvoke", waveEnd);
        }
        CheckWaveIsAlive();
    }


    void CreateWave(){
        GameObject enemyClone = Instantiate(Enemy, Spawn, Quaternion.identity) as GameObject;
        AmountOfEnemy++;}
}