using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1 : MonoBehaviour
{
    [SerializeField]float horizontalSpeed = 10f; 
    [SerializeField]float jumpForce = 6f;
    bool isStanding;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement();
        if((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow)) && isStanding)
        {
            jump();
        }
    }

    void movement()
    {
        //Move left right
        float moveSpeed = Input.GetAxis("Horizontal") * horizontalSpeed * Time.deltaTime;
        transform.Translate(moveSpeed, 0, 0);
    }

    void jump()
    {
         rb.velocity = Vector2.up * jumpForce;
         isStanding = false;
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.tag == "Ground")
        {
            isStanding = true;
        }
    }
}