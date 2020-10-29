using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{  public float speed=100;
    private Rigidbody2D rb; 
    private bool faceRight=true;
    
private Vector2 moveVelocity;
    void Start()
    {
        
        rb=GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical"));
        moveVelocity=moveInput.normalized*speed;
        float move = Input.GetAxis("Horizontal");
        if(move > 0 && !faceRight)
            //отражаем персонажа вправо
            Flip();
        //обратная ситуация. отражаем персонажа влево
        else if (move < 0 && faceRight)
            Flip();
               
    }
    void Flip()
    {
         //меняем направление движения персонажа
        faceRight = !faceRight;
        //получаем размеры персонажа
        Vector3 theScale = transform.localScale;
        //зеркально отражаем персонажа по оси Х
        theScale.x *= -1;
        //задаем новый размер персонажа, равный старому, но зеркально отраженный
        transform.localScale = theScale;
    }
     
    void FixedUpdate()
    {
        rb.MovePosition(rb.position+moveVelocity*Time.fixedDeltaTime);
        
    }

}
