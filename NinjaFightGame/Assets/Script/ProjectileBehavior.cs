using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehavior : MonoBehaviour
{
    public bool facingRight;
    public RigidBody projectileRB;
    public speed = 15;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Movement(facingRight){
        if(facingRight == true){ 
        projectileRB.AddForce(transform.forward * forwardInput * speed);}
        if(facingRight == false){
           projectileRB.AddForce(transform.forward * forwardInput * speed); 
        }

    }

}