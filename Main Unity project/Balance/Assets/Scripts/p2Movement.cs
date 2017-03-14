using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p2Movement : MonoBehaviour
{

    private float Velocity;
    public float Speed;



    void Update()
    {

        Velocity = 0f;


        if (Input.GetKey(KeyCode.RightArrow))
        {
            Velocity = Speed;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Velocity = -Speed;
        }

        GetComponent<Rigidbody2D>().velocity = new Vector2(Velocity, GetComponent<Rigidbody2D>().velocity.y);
    }
}