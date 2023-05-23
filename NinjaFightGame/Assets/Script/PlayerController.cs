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


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
    
      if (Input.GetKeyDown(KeyCode.A)){
         transform.Rotate(Vector3.up * 180);
      }
      if (Input.GetKeyDown(KeyCode.D)){
         transform.Rotate(Vector3.up * 180);
      }
      float forwardInput = Input.GetAxis("Horizontal");
        playerRB.AddForce(transform.forward * forwardInput * speed);
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
