using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class CountdownController : MonoBehaviour
{
    public Text countDownText;
    public GameObject car;
    public TimerController timerController;
    
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(nameof(Countdown));
    }

    IEnumerator Countdown()
    {
        yield return new WaitForSeconds(0.8f);

        countDownText.text = "3";
        countDownText.gameObject.SetActive(true);
        yield return new WaitForSeconds(1f);
        countDownText.gameObject.SetActive(false);
        
        countDownText.text = "2";
        countDownText.gameObject.SetActive(true);
        yield return new WaitForSeconds(1f);
        countDownText.gameObject.SetActive(false);
        
        countDownText.text = "1";
        countDownText.gameObject.SetActive(true);
        yield return new WaitForSeconds(1f);
        countDownText.gameObject.SetActive(false);
        
        countDownText.text = "GO!";
        countDownText.gameObject.SetActive(true);

        car.GetComponent<CarUserControl>().enabled = true;
        timerController.gameObject.SetActive(true);
        
        yield return new WaitForSeconds(1f);
        countDownText.gameObject.SetActive(false);

    }
}
