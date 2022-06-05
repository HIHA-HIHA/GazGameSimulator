using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

using static UnityEditor.Progress;

public class Respawner : MonoBehaviour
{
    [SerializeField]
    private GameObject objectForSpawn;

    [SerializeField]
    private GameObject objectForDelete;

    [SerializeField]
    private UnityEvent onRespawn;

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.R))
        {
            RespawnObjects();
        }
    }

    public void RespawnObjects()
    {
        if(objectForDelete != null)
            Destroy(objectForDelete);

        GameObject spawnedObject = Instantiate(objectForSpawn);

        objectForDelete = spawnedObject;

    }
}
