using System;
using UnityEngine;

public class Clock : MonoBehaviour
{
    [SerializeField]
    Transform hoursPivot = default, minutesPivot = default, secondsPivot = default;

    const float hoursToDegrees = -30f, minutesToDegrees = -6f, secondsToDegrees = -6f;

    void Update()
    {
        TimeSpan time = DateTime.Now.TimeOfDay;
        //TotalHours是一天的当前小时数，最大为24
        hoursPivot.localRotation = Quaternion.Euler(0f, 0, hoursToDegrees * (float) time.TotalHours);
        //TotalMinutes是一天的总分钟数，最大为24 * 60 = 1440
        minutesPivot.localRotation = Quaternion.Euler(0f, 0, minutesToDegrees * (float)time.TotalMinutes);
        //TotalSeconds是一天的总秒钟数，最大为24 * 60 * 60 = 86400
        secondsPivot.localRotation = Quaternion.Euler(0f, 0, secondsToDegrees * (float) time.TotalSeconds);
    }

}