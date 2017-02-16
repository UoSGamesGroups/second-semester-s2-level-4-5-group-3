using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cleaner : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Items")
        {
            Destroy(col.gameObject);
        }
        if (col.gameObject.tag == "smallPlatform")
        {
            Destroy(col.gameObject);
        }
    }
}
