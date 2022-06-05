using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PressureUI : MonoBehaviour
{
    [SerializeField]
    private PressureManager managerPressure;

    [SerializeField]
    private Image pressureImage;

    private void Start()
    {
        managerPressure.OnChangePressure += SetPressure;
    }

    public void SetPressure(float value)
    {
        pressureImage.fillAmount = value;
    }
}
