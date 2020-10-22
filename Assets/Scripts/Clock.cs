using System;
using UnityEngine;

public class Clock : MonoBehaviour 
{
    const float hoursToDegrees = -30f, minutesToDegrees = -6f, secondsToDegrees = -6f;

    [SerializeField]
    Transform hoursPivot = default, minutesPivot = default, secondsPivot = default;
    [SerializeField]
    Boolean continuousRotation = true;

    void Update() {
        if (continuousRotation) {
            TimeSpan time = DateTime.Now.TimeOfDay;
            hoursPivot.localRotation = 
                Quaternion.Euler(0f, 0f, hoursToDegrees * (float) time.TotalHours);
            minutesPivot.localRotation = 
                Quaternion.Euler(0f, 0f, minutesToDegrees * (float) time.TotalMinutes);
            secondsPivot.localRotation = 
                Quaternion.Euler(0f, 0f, secondsToDegrees * (float) time.TotalSeconds);
        } else {
            DateTime time = DateTime.Now;
            hoursPivot.localRotation = 
                Quaternion.Euler(0f, 0f, hoursToDegrees * time.Hour);
            minutesPivot.localRotation = 
                Quaternion.Euler(0f, 0f, minutesToDegrees * time.Minute);
            secondsPivot.localRotation = 
                Quaternion.Euler(0f, 0f, secondsToDegrees * time.Second);
        }
    }
}
