using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision : MonoBehaviour
{
    Rigidbody2D rb;

    float angularVelocity = 0;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Basket")
        {
            rb = GetComponent<Rigidbody2D>();
            Vector3 reset = new Vector3(0, 6, 0);
            rb.MovePosition(reset);
            rb.angularVelocity = angularVelocity;
            rb.velocity = new Vector2(0.0f, 0.0f);


            ScoreScript.scoreValue += 10;

        }

        if (collision.gameObject.tag == "BasketTop")
        {
            rb = GetComponent<Rigidbody2D>();
            Vector3 reset = new Vector3(0, 6, 0);
            rb.MovePosition(reset);
            rb.angularVelocity = angularVelocity;
            rb.velocity = new Vector2(0.0f, 0.0f);


            ScoreScript.scoreValue += 25;

        }
    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ground")
        {
            rb = GetComponent<Rigidbody2D>();
            Vector3 reset = new Vector3(0, 6, 0);
            rb.MovePosition(reset);
            //rb.angularVelocity = angularVelocity;
            rb.velocity = new Vector2(0.0f, 0.0f);
        }
    }
}
