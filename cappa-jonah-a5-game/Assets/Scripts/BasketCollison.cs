using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketCollison : MonoBehaviour
{
    public BallCollision ball = new BallCollision();

    void OnCollisionEnter2D(Collision2D collision)
    {
       if (collision.gameObject.name == "Ball")
        {

        }
    }

    void OnCollisionStay2D(Collision2D collision)
    {
  
    }

    void OnCollisionExit2D(Collision2D collision)
    {
    
    }
}
