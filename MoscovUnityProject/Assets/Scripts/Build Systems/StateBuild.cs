using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StateBuild : MonoBehaviour
{
    public static StateBuild Instanse;

    [SerializeField]
    private UnityEvent onFullCorrect;

    [SerializeField]
    private bool[] usedPlaces;

    private void Awake()
    {
        if (!Instanse)
        {
            Instanse = this;
        }
        else
        {
            Destroy(gameObject);
        }
        
    }

   
    public void TurnPlace(int id)
    {
        
        usedPlaces[id] = true;
        CheckPlaced();
    }

    private void CheckPlaced()
    {
        foreach(bool place in usedPlaces)
        {
            if (!place)
            {
                return;
            }
        }
        onFullCorrect?.Invoke();
    }
    
}
