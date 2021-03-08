using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapController : MonoBehaviour
{
    public TimerController timerController;
    public GameObject halfPointTrigger;
    public Text lapNumberText;

    private int LapCount = 1;

    private void Start()
    {
        lapNumberText.text = LapCount.ToString("D2");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "ColliderBottom" && other.CompareTag("Player"))
        {
            halfPointTrigger.SetActive(true);
            this.gameObject.SetActive(false);
            timerController.SetBestTime();
            TimerController.StartTime = 0f;

            LapCount++;
            lapNumberText.text = LapCount.ToString("D2");
        }
    }
}
