using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
	{
		// уничтожить объект по истечению указанного времени (секунд), если пуля никуда не попала
	}
		
	void OnTriggerEnter2D(Collider2D other) {
		Destroy(gameObject);
	}
}
