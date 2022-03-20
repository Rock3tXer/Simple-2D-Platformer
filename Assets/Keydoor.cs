using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keydoor : MonoBehaviour
{
    [SerializeField] int Key1 = 0;
    public Text keyText;
    [SerializeField] float destroyTime = 0f;

    void Start(){
        keyText.text = "Key: " + Key1;  
    }
    
    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Key1")
        {
            Key1 = 1;
            keyText.text = "Key: " + Key1; 
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
           Key1 = 0;
           keyText.text = "Key: " + Key1; 
       }
   }
}
