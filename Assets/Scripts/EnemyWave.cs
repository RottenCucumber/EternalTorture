using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWave : MonoBehaviour
{
    public GameObject Enemy;
    public Transform Spawn;
    public int AmmountOfEnemy;
    private float timeOut;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateWave", 2.0f, 0.5f);
        Invoke("CancelInvoke", 4.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void CreateWave(){
        GameObject enemyClone = Instantiate(Enemy, Spawn.position, Quaternion.identity) as GameObject;}


    
}