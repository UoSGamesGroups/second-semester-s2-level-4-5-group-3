using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cleaner : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Items" || col.gameObject.tag == "smallPlatform" || col.gameObject.tag == "bigPlatform" || col.gameObject.tag == "Collided" || col.gameObject.tag == "Cars")
        {
            Destroy(col.gameObject);
        }
    }
}
