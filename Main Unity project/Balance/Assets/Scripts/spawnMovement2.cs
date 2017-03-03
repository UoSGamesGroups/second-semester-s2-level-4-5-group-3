using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnMovement2 : MonoBehaviour
{

    void Start()
    {
        InvokeRepeating("SetRandomPos", 0, 5);
    }

    void SetRandomPos()
    {
        Vector3 temp = new Vector3(Random.Range(3.2f, 7.0f), Random.Range(3.0f, 2.0f), Random.Range(-0f, 0f));
        transform.position = temp;
    }
}
