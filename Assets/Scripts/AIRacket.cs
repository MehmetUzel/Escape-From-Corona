using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIRacket : racket
{
    Transform ball { get { return FindObjectOfType<ball>().transform; } }

    protected override void Move()
    {
        float distance = Vector2.Distance(ball.position, transform.position);
        
        if( distance < 4 )
        {
            if (ball.position.y <= transform.position.y)
            {
                if (transform.position.y < 4.4f && transform.position.y > 2.4f)
                {
                    rb2.velocity = Vector2.down * movespeed*5;
                }
                else
                {
                    rb2.velocity = Vector2.up * movespeed;
                }
             }
            else if (ball.position.y > transform.position.y)
            {
                if (transform.position.y > -5.1f && transform.position.y < -3.1f)
                {
                    rb2.velocity = Vector2.up * movespeed*5;
                }
                else
                {
                    rb2.velocity = Vector2.down * movespeed;
                }
            }
        }
        //else if (distance < 4)
        //{
        //    if (ball.position.y > transform.position.y)
        //    {
        //        rb2.velocity = Vector2.up * movespeed;
        //    }
        //    else
        //    {
        //        rb2.velocity = Vector2.down * movespeed;
        //    }
        //}

    }

    
}
