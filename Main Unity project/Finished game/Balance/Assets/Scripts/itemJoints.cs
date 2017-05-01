using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class itemJoints : MonoBehaviour
{
    public float Breakforce = 13.0f;

    public bool contact;
    public bool jointBroken = false;

    void OnJointBreak(float breakForce)
    {
        Debug.Log("A joint has just been broken!, force: " + breakForce);
        contact = false;
        jointBroken = true;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Items" || col.gameObject.tag == "p1" ||col.gameObject.tag == "p2" )
        {
            contact = true;

            if (contact == true && jointBroken == false)
            {
                SpringJoint2D newJoint = gameObject.AddComponent<SpringJoint2D>();

                newJoint.enableCollision = true;
                newJoint.connectedBody = col.rigidbody;
                newJoint.distance = 0.0005f;
                newJoint.autoConfigureDistance = true;
                newJoint.breakForce = Breakforce;

                // Debug.Log("Joint Created");
            }
            
        }
    }

}
