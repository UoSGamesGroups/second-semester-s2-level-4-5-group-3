using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Movement : MonoBehaviour
{

    private float Velocity;
    public float Speed;

    public Button Left;
    public Button Right;
    public Button Left2;
    public Button Right2;

    public GameObject player;
    public GameObject player2;

    void Start()
    {
        Button btnLeft = Left.GetComponent<Button>();
        Button btnRight = Right.GetComponent<Button>();
        Button btnLeft2 = Left2.GetComponent<Button>();
        Button btnRight2 = Right2.GetComponent<Button>();
        btnLeft.onClick.AddListener(movePlayerLeft);
        btnRight.onClick.AddListener(movePlayerRight);
        btnLeft2.onClick.AddListener(movePlayerLeft2);
        btnRight2.onClick.AddListener(movePlayerRight2);
    }

    void movePlayerLeft()
    {
        Velocity = -Speed;
        player.GetComponent<Rigidbody2D>().velocity = new Vector2(Velocity, player.GetComponent<Rigidbody2D>().velocity.y);
    }

    void movePlayerRight()
    {
        Velocity = Speed;
        player.GetComponent<Rigidbody2D>().velocity = new Vector2(Velocity, player.GetComponent<Rigidbody2D>().velocity.y);
    }

    void movePlayerLeft2()
    {
        Velocity = -Speed;
        player2.GetComponent<Rigidbody2D>().velocity = new Vector2(Velocity, player2.GetComponent<Rigidbody2D>().velocity.y);
    }

    void movePlayerRight2()
    {
        Velocity = Speed;
        player2.GetComponent<Rigidbody2D>().velocity = new Vector2(Velocity, player2.GetComponent<Rigidbody2D>().velocity.y);
    }


    void Update()
    {

        if (Input.GetKey(KeyCode.D))
        {
            Velocity = Speed;
            player.GetComponent<Rigidbody2D>().velocity = new Vector2(Velocity, player.GetComponent<Rigidbody2D>().velocity.y);
        }

        if (Input.GetKey(KeyCode.A))
        {
            Velocity = -Speed;
            player.GetComponent<Rigidbody2D>().velocity = new Vector2(Velocity, player.GetComponent<Rigidbody2D>().velocity.y);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Velocity = -Speed;
            player2.GetComponent<Rigidbody2D>().velocity = new Vector2(Velocity, player2.GetComponent<Rigidbody2D>().velocity.y);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            Velocity = Speed;
            player2.GetComponent<Rigidbody2D>().velocity = new Vector2(Velocity, player2.GetComponent<Rigidbody2D>().velocity.y);
        }



    }
}