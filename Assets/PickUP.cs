using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUP : MonoBehaviour
{
    int score = 0;
    int Key1 = 0;
    [SerializeField] float destroyTime = 0f;
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Pickup")
        {
            score = score + 1;
            Debug.Log("Score: " + score);
            Destroy(other.gameObject, destroyTime);
        }
        if(other.tag == "Key1")
        {
            Key1 = 1;
            Debug.Log("Key: " + Key1);
            Destroy(other.gameObject, destroyTime);
        }
        
    }
    
    void OnCollisionEnter2D (Collision2D collision)
   {
       if (collision.gameObject.tag == "Door1" && Key1 == 1)
       {
           Debug.Log("Open the Doors");
           Destroy(collision.gameObject);
       }
   }
}
