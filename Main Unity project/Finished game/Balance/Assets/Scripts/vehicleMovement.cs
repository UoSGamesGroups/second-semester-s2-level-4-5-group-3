using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vehicleMovement : MonoBehaviour {

    public float speed = 10.0f;


    void Update ()
    {
        float step = speed * Time.deltaTime;
        transform.Translate(Vector3.left * step, Space.World);
    }
}
