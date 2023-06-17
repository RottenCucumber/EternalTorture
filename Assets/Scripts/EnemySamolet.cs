using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySamolet : MonoBehaviour
{
    public int Health;
    public bool isFiring;
    public float fireRate = 1.0f;
    public float speed= 20;
    public Rigidbody2D bullet;
    public Transform gunPoint;
    private PlayerFire currentFire;
    private float curTimeout = 100;
    private Health enemyHealth;


    void Start()
    {
        
    }




    void Update()
    {
        if(isFiring == true){
            if(gunPoint.transform.position.y > 3){
            //Debug.Log("Я выше");
            currentFire = GetComponent<PlayerFire>();
            InvokeRepeating("currentFire.Fire(false, curTimeout, gunPoint, bullet, speed, fireRate)", 0f, 0.4f);
            Invoke("CancelInvoke", 2f);}
            //currentFire.Fire(false, curTimeout, gunPoint, bullet, speed, fireRate);}

		}

        enemyHealth = GetComponent<Health>();
        enemyHealth.checkEnemyHealth(Health);
    }
    
}
