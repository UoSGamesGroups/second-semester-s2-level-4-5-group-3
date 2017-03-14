using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class itemJoints : MonoBehaviour
{
    public float Breakforce = 10.0f;

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Items" || col.gameObject.tag == "p1" ||col.gameObject.tag == "p2")
        {
            FixedJoint2D newJoint = gameObject.AddComponent<FixedJoint2D>();
          //  JointLimits limits = newJoint.limits;
            newJoint.connectedBody = col.rigidbody;
            newJoint.breakForce = Breakforce;
         //   newJoint.useLimits = true;   
            Debug.Log("Joint Created");
            
        }
    }
}
