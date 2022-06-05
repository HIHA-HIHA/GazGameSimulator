using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class SpawnerObjectsForBuild : MonoBehaviour
{
    [SerializeField]
    private GameObject prefab;

    [SerializeField]
    private Transform spawnPoint;

    private void Start()
    {
        SpawnObject();
    }

    public void SpawnObject()
    {
        GameObject spawnedObject = Instantiate(prefab, spawnPoint);
        spawnedObject.GetComponent<ObjectForSpawn>().spawner = this;
    }
}
