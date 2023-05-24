using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRB;
    public float speed = 15.0f;
    [SerializeField] bool isOnGround;
    public float JumpForce = 15.0f;
    public bool facingRight;
    public GameObject projectileFire;
    public GameObject projectileLightning;
    public bool element;
    private float angle = 180;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    float forwardInput = Input.GetAxis("Vertical");
    playerRB.AddForce(transform.forward * forwardInput * speed);
    
      if (Input.GetKeyDown(KeyCode.A)){
        transform.RotateAround(transform.position, Vector3.up, angle);
      }
      if (Input.GetKeyDown(KeyCode.D)){
        transform.RotateAround(transform.position, Vector3.up, angle);
        playerRB.AddForce(transform.forward * forwardInput * speed);
      }
      
      if (Input.GetKeyDown(KeyCode.Space)) 
      {
        playerRB.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
        isOnGround = false;}
    
      if (Input.GetKeyDown(KeyCode.F)){
        if(element == true);
        {
          if(facingRight == false)
          {
         
          }
          if(facingRight == true)
          {
          
          }
        }
        if(element == false);
        {
          Instantiate(projectileLightning, transform.position, projectileLightning.transform.rotation);
        }
    }

    }
}
