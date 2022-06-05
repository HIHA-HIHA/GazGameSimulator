using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatorGameObjects : MonoBehaviour
{
    [SerializeField]
    private GameObject[] gameObjects;

    public void ActivateObjects()
    {
        foreach (var gameObject in gameObjects)
        {
            gameObject.SetActive(true);
        }
    }
}
