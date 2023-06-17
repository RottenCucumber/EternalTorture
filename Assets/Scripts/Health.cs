using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    private int countImpact = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter2D(Collider2D other) {
        countImpact++;
	}

    public void checkHealth(int health){
        if(countImpact >= health){
            Destroy(gameObject);
            }
    }
    public void checkEnemyHealth(int health){
        if(countImpact >= health && countImpact != 0){
            Destroy(gameObject);
            EnemyWave.countDead += 1;
            //Debug.Log("Один убит");
            //FindObjectOfType<EnemyWave>().Signal(countDead);
            }
    }
}
