using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectForSpawn : MonoBehaviour
{
    public SpawnerObjectsForBuild spawner { get; set; }

    public void Take()
    {
        spawner.SpawnObject();
        Destroy(this);
    }

    public void DestroyComponent()
    {
        Destroy(this);
    }
}
