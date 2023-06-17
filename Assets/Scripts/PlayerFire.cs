using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    private float curTimeout;
    
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Fire(bool who, float curTimeout, Transform gunPoint, Rigidbody2D bullet, float speed, float fireRate){
    if(who == true){
        curTimeout += Time.deltaTime;
		if(curTimeout > fireRate)
		{
			curTimeout = 0;
			Rigidbody2D clone = Instantiate(bullet, gunPoint.position, Quaternion.identity) as Rigidbody2D;
			clone.velocity = transform.TransformDirection(gunPoint.up * speed);
			clone.transform.up = gunPoint.up;
            
		}
        
    }
    else{
        curTimeout += Time.deltaTime;
		if(curTimeout > fireRate)
		{
            curTimeout = 0;
            speed = -speed;
            Rigidbody2D clone = Instantiate(bullet, gunPoint.position, Quaternion.identity) as Rigidbody2D;
		    clone.velocity = transform.TransformDirection(gunPoint.up * speed);
		    clone.transform.up = gunPoint.up;
            Debug.Log("СТРЕЛЯЮ");
        }
		}
    }
}
