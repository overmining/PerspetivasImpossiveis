using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public Text timeText;

    public float timeValue = 90;

    void Update()
    {
        // Contar o tempo
        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        // Mostrar o tempo
        DisplayTime(timeValue);
    }

    void DisplayTime(float timeDisplay)
    {
        if(timeDisplay < 0)
        {
            timeDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timeDisplay / 60);
        float seconds = Mathf.FloorToInt(timeDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
