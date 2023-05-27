using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Camera mainCamera;
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate() {
        Vector2 currentMousePos =  mainCamera.ScreenToWorldPoint(Input.mousePosition);
        currentMousePos.x = Mathf.Clamp(currentMousePos.x, -7.06f, 7.06f);
        currentMousePos.y = Mathf.Clamp(currentMousePos.y, -4.3f, 4.3f);
        transform.position = Vector2.MoveTowards(transform.position, currentMousePos, speed*Time.deltaTime);
    }
}
