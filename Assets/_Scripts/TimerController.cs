using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    public Text timerText;
    public Text bestTimerText;
    public static float StartTime = 0f;
    private float bestTime = Mathf.Infinity;
    
    void Update()
    {
        StartTime += Time.deltaTime;

        SetLapTime();
    }

    private void SetLapTime()
    {
        int minutes = ((int) StartTime / 60);
        float seconds = (StartTime % 60);

        if (minutes < 10f)
        {
            if (seconds < 10f)
                timerText.text = "0" + minutes.ToString() + ":0" + seconds.ToString("f2");
            
            else
                timerText.text = "0" + minutes.ToString() + ":" + seconds.ToString("f2");
        }
        else
        {
            if (seconds < 10f)
                timerText.text = minutes.ToString() + ":0" + seconds.ToString("f2");
            
            else
                timerText.text = minutes.ToString() + ":" + seconds.ToString("f2");
        }
    }

    public void SetBestTime()
    {
        if (StartTime <= bestTime)
        {
            int minutes = ((int) StartTime / 60);
            float seconds = (StartTime % 60);

            if (minutes < 10f)
            {
                if (seconds < 10f)
                    bestTimerText.text = "0" + minutes.ToString() + ":0" + seconds.ToString("f2");

                else
                    bestTimerText.text = "0" + minutes.ToString() + ":" + seconds.ToString("f2");
            }
            else
            {
                if (seconds < 10f)
                    bestTimerText.text = minutes.ToString() + ":0" + seconds.ToString("f2");

                else
                    bestTimerText.text = minutes.ToString() + ":" + seconds.ToString("f2");
            }

            bestTime = StartTime;
        }

    }
}
