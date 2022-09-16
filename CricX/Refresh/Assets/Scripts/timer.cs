using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class timer : MonoBehaviour
{
     public float startTime;
     public float currentTime;
     bool timeStarted = false;

    public TMP_Text timerTxt;
    void Start()
    {
        currentTime = startTime;
        timerTxt.text = currentTime.ToString();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            timeStarted = true;
        }
        if (timeStarted)
        {
            currentTime -= Time.deltaTime;
            if (currentTime <= 0)
            {
                Debug.Log("Time is up");
                timeStarted = false;
                currentTime = 0;
            }
            if (currentTime >= 10)
            {
                timerTxt.text = currentTime.ToString("f0");
            }
            else
            {
                timerTxt.text = currentTime.ToString("f1");
            }
            

        }

    }
}
