using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 3;
    public int currentHealth;
    public int subtractHealth = -1;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }
    
    void TakeDamage(int amount)
    {
        currentHealth -= amount;

        if(currentHealth <=0)
        {
            // we're dead
            // play death animation
            //game over
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
    if(collision.gameObject.CompareTag("enemy"))
    {
        subtractHealth;
    }
    }
}
