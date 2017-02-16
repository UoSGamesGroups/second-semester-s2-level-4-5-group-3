using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    public List<GameObject> prefabList = new List<GameObject>();

    public Transform SpawnerPos;
    public float time = 5;

    void Start()
    {
        StartCoroutine(spawnTime());

    }
        IEnumerator spawnTime()
            {
        int prefabIndex = UnityEngine.Random.Range(0, 9);
        Debug.Log(prefabIndex);
        Instantiate(prefabList[prefabIndex], SpawnerPos.transform.position, transform.rotation);
            yield return new WaitForSeconds(time);

        StartCoroutine(spawnTime());


    }
  }

