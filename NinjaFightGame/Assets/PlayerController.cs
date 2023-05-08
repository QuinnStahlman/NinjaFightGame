using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Variables
    public Rigidbody playerRB;
    public float speed = 5.0f;
    private GameObject focalPoint;
    public float SetForce = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        playerRB.SetForce(transform.forward * forwardInput * speed);
    }

}