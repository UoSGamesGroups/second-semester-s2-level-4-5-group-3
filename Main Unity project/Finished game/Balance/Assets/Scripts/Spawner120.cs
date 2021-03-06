﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner120 : MonoBehaviour {
    public List<GameObject> prefabList = new List<GameObject>();

    public Transform SpawnerPos;
    public float time = 5;
	public float spawntimer;


    void Start()
    {
        StartCoroutine(spawnTime());
		spawntimer = 120; 
    }
        IEnumerator spawnTime()
            {
        int prefabIndex = UnityEngine.Random.Range(0, 9);
       // Debug.Log(prefabIndex);
        Instantiate(prefabList[prefabIndex], SpawnerPos.transform.position, transform.rotation);
            yield return new WaitForSeconds(time);

        StartCoroutine(spawnTime());

    }

	void FixedUpdate (){

		spawntimer -= Time.deltaTime;

		if (spawntimer <= 1) 
		{
			StopAllCoroutines ();
		}

	}
  }

