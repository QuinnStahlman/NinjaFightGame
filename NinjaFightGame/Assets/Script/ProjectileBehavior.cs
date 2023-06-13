using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehavior : MonoBehaviour
{
    public Rigidbody projectileRB;
    public float speed = 17.0f;
    public bool facingRight;
    private PlayerController playerController;
    public float forwardInput = 15.0f;
    public GameObject projectile;
    
    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        facingRight = playerController.facingRight;
        Destroy(projectile, 5);
    }

    // Update is called once per frame
    void Update()
    {
        if(facingRight == true)
        { 
        projectileRB.AddForce(transform.forward  * speed);
        }
        if(facingRight == false)
        {
           transform.Rotate(Vector3.up * 180);
           projectileRB.AddForce(transform.forward * speed); 
        }
    }

}
