using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 3f;
    private bool grounded = false;

    void Start()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Suelo")
        {
            grounded = true; // El objeto está en el suelo
        }

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
        if (Input.GetKeyDown(KeyCode.Space) && grounded){
            transform.position += new Vector3(0, moveSpeed*70, 0);
            grounded = false;
        }
    }

    
}
