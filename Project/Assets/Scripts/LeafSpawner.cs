using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeafSpawner : MonoBehaviour
{
    [SerializeField] GameObject leafPrefab;
    [SerializeField] float spawnRate;

    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        Instantiate(leafPrefab, new Vector3(Random.Range(-10, 10), 7), Quaternion.identity);

        yield return new WaitForSeconds(spawnRate);

        StartCoroutine(Spawn());
    }
}
