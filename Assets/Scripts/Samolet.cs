using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Samolet : MonoBehaviour
{
    public bool Immortal;
    public int Health;
    public float fireRate = 0.1f;
    public float speed= 20;
    public Rigidbody2D bullet;
    public Transform gunPoint;
    private PlayerFire currentFire;
    private Health playerHealth;
    private float curTimeout = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
          if(Input.GetMouseButton(0))
		{
            currentFire = GetComponent<PlayerFire>();
			currentFire.Fire(true, curTimeout, gunPoint, bullet, speed, fireRate);
            curTimeout = 0;
		}
		else
		{
			curTimeout = 100;
		}

        if(Immortal == false){
            playerHealth = GetComponent<Health>();
            playerHealth.checkHealth(Health);}
    }
}
