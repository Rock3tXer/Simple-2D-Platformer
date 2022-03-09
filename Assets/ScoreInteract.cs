using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreInteract : MonoBehaviour
{
    int score = 0;
    [SerializeField] float destroyTime = 0f;

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Pickup")
        {
            score = score + 1;
            Debug.Log("Score: " + score);
            Destroy(other.gameObject, destroyTime);
        } 
    }
}
