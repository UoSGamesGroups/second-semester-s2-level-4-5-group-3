using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portals : MonoBehaviour {

    void Start()
    {
        for(int y = 0; y < 1; y++)
        {
            for(int x = 0; x < 1; x++)
            {
                GameObject Portal = (GameObject)Instantiate(Resources.Load("Portals"));
                Portal.AddComponent<Rigidbody>();
                Portal.transform.position = new Vector3(0, 10, 0);
            }
        }
    }
}
