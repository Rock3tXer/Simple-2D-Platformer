using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreInteract : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;
    [SerializeField] float destroyTime = 0f;
    
    void Start(){
        scoreText.text = "Score: " + score; 
    }
   
    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Pickup")
        {
            Debug.Log("Score: " + score);
            Destroy(other.gameObject, destroyTime);
            score = score + 500;
            scoreText.text = "Score: " + score; 
        } 
    }
    
    //Restart if taken spike
    void OnCollisionEnter2D (Collision2D other)
    {
     if(other.gameObject.tag == "Spikes")
          SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
