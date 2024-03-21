using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 3f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        checkMovement(speed);
    }

     public void checkMovement(float speed){
        float moveSpeed = speed * Time.deltaTime;

        if(Input.GetKey(KeyCode.W)){
            transform.position += new Vector3(0, 0, moveSpeed);
        }
        if(Input.GetKey(KeyCode.S)){
            transform.position += new Vector3(0, 0, -moveSpeed);
        }
        if(Input.GetKey(KeyCode.A)){
            transform.position += new Vector3(-moveSpeed, 0, 0);
        }
        if(Input.GetKey(KeyCode.D)){
            transform.position += new Vector3(moveSpeed, 0, 0);
        }
    }
}
