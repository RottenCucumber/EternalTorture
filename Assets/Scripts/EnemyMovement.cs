using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private Vector2 NextPoint;
    public float speed;
    private Vector2 pos;

    // Start is called before the first frame update
    void Start()
    {
        pos = new Vector2(-7,0);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    void FixedUpdate() {

    }
    void Move(){
         pos.y = Mathf.Sin(0.5f*pos.x)+3;
        NextPoint = pos;
        transform.position = Vector2.MoveTowards(transform.position, NextPoint, speed);
        pos.x = pos.x + 0.01f;
        if(pos.x >= 8){
            pos.x = -8;
            }
    }
}
