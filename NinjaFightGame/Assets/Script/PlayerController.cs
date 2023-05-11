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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      float forwardInput = Input.GetAxis("Horizontal");
        playerRB.AddForce(transform.forward * -forwardInput * speed);
    
      if (Input.GetKeyDown(KeyCode.A)){
          facingRight = false;
      }
      if (Input.GetKeyDown(KeyCode.D)){
          facingRight = true;
      }
      if (Input.GetKeyDown(KeyCode.Space)) 
        {
          playerRB.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
          isOnGround = false;}
    
      if (Input.GetKeyDown(KeyCode.F)){
        
    }

    }
}
