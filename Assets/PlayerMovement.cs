using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Volanie Controlleru
    public CharackterController controller;
    float runSpeed = 30f;
    float horizontalMove = 0f;
    bool jumper = false;

    //Kontrola inputu
    void Update()
    {
        //Chodenie vpravo a vlavo
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
      
        //Skakanie
        if(Input.GetButtonDown("Jump")){
            jumper = true;
        }
    }

    //Nastavenie pohybu
    void FixedUpdate()
    {
        //Vyuzivanie funkcii kontrolleru
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jumper);
        jumper = false;
    }
}
