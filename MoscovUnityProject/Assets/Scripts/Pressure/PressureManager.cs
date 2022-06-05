using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressureManager: MonoBehaviour
{


    public Action<float> OnChangePressure;

    private float pressure;

    public void SetPressure(float value)
    {
        pressure = value;
        OnChangePressure?.Invoke(pressure);
    }
}
