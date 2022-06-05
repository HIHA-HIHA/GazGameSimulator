using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class PressureController : MonoBehaviour
{
    [SerializeField]
    private PressureManager managerPressure;

    [SerializeField]
    private LinearMapping linearMapping;

    public void UpdatePressure()
    {
        managerPressure.SetPressure(linearMapping.value);
    }
}
