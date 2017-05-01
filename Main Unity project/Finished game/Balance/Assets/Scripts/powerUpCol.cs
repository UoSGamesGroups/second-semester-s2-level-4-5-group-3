using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUpCol : MonoBehaviour
 {

   void OnCollisionEnter2D(Collision2D col_p)
    {
        if (col_p.gameObject.tag == "smallPlatform")
        {
            Destroy(col_p.gameObject);
            transform.localScale -= new Vector3(0.2F, 0, 0);
        }
        if (col_p.gameObject.tag == "bigPlatform")
        {
            Destroy(col_p.gameObject);
            transform.localScale += new Vector3(0.2F, 0, 0);
        }
    }
}
