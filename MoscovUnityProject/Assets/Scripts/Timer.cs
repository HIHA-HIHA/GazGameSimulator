using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    [SerializeField]
    private UnityEvent onEndTimer;

    [SerializeField]
    private TMP_Text nowTime;

    [SerializeField]
    private TMP_Text lastTime;


    private bool inWork;
    private bool canWork;
    private int time;

    public void StartTimer()
    {
        if (!inWork)
        {
            canWork = true;
            StartCoroutine(TimerCorrutine());
        }
    }

    private IEnumerator TimerCorrutine()
    {
        inWork = true;
        time = 0;
        while (canWork)
        {
            nowTime.text = time + " Секунд";
            time++;
            yield return new WaitForSeconds(1);
        }
    }
    public void StopTimer()
    {

        canWork = false;
        StopCoroutine(TimerCorrutine());
        lastTime.text = "Прошлое время: "+time +" секунд";
        onEndTimer?.Invoke();
        inWork = false;
    }

    
}
