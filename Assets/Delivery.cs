using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    

    [SerializeField] float destroyDelay = 0.1f;
    bool hasPackage;
    public LogicScript logic;

   

    private void OnCollisionEnter2D(Collision2D other)
    {   
        Debug.Log("You have crashed!");

    }
        
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Football" && !hasPackage)
        {
            Debug.Log("Football picked up!");
            hasPackage = true;
            Destroy(other.gameObject, destroyDelay);
        }

        if (other.tag == "Footballers" && hasPackage)
        {
            Debug.Log("Football has been delivered to the footballers!");
            hasPackage = false;
        }
       
         
    }
}
