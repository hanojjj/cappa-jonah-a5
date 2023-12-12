using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketCollison : MonoBehaviour
{

    

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ball")
        {
            collision.gameObject.GetComponent<Rigidbody2D>().sharedMaterial.bounciness = 1;

        }

    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ball")
        {
            collision.gameObject.GetComponent<Rigidbody2D>().sharedMaterial.bounciness = 0;

        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ball")
        {
            collision.gameObject.GetComponent<Transform>().position = new Vector3(0, 6, 0);

            collision.gameObject.GetComponent<Rigidbody2D>().sharedMaterial.bounciness = 1;

        }
    }
}
