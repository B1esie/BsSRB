﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{  public float speed=5;
    private Rigidbody2D rb; 
private Vector2 moveVelocity;
    void Start()
    {
        
        rb=GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical"));
        moveVelocity=moveInput.normalized*speed;
    }
   
    void FixedUpdate()
    {
        rb.MovePosition(rb.position+moveVelocity*Time.fixedDeltaTime);
        
    }

}
