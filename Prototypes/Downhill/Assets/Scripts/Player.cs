using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float jumpSpeed = 10f;
    public bool Is_Grounded;
    private Player player;

    void Start()
    {
        player = gameObject.GetComponentInParent<Player>();
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        player.Is_Grounded = true;
    }

    void OnCollisionExit2D(Collision2D coll)
    {
        player.Is_Grounded = false;
    }

    void FixedUpdate ()
    {
        if (Input.GetKey(KeyCode.Space)&&Is_Grounded==true)
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpSpeed, ForceMode2D.Force);

    }
}
