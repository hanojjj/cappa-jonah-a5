using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 3f;


    void Start()
    {
        
    }

    void Update()
    {

        Vector3 movement = new Vector3();
        

        bool isHoldingLeft = Input.GetKey(KeyCode.LeftArrow);
        bool isHoldingRight = Input.GetKey(KeyCode.RightArrow);
        bool isLeaningLeft = Input.GetKey(KeyCode.N);
        bool isLeaningRight = Input.GetKey(KeyCode.M);

        if (isHoldingLeft)
            movement.x -= speed;

        if (isHoldingRight)
            movement.x += speed;

        if (isLeaningLeft)
        {
            transform.eulerAngles = Vector3.forward * 30;
        }
        else
        {
            transform.eulerAngles = new Vector3(0,0,0);
        }

        if (isLeaningRight)
        {
            transform.eulerAngles = Vector3.forward * -30;
        }




        transform.position += movement * Time.deltaTime;
        


    }
}
