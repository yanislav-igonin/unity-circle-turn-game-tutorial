using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
 
    public Transform spawnPoint;
    [SerializeField] Vector2 spawnRange;
    [SerializeField] GameObject spawnObject;

    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(1);
        Vector2 pos = spawnPoint.position + new Vector3(0, Random.Range(-spawnRange.y, spawnRange.y));
        Instantiate(spawnObject, pos, Quaternion.identity);
        Repeat();
    }

    void Repeat()
    {
        StartCoroutine(Spawn());
    }
}
