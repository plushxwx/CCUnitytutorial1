using System;
using UnityEngine;

public class Clock : MonoBehaviour {

    const float HOURSTODEGREES = -30;
    const float MINUTESTODEGREES = -6;
    const float SECONDSTODEGREES = -6;

    [SerializeField] Transform hoursPivot;
    [SerializeField] Transform minutesPivot;
    [SerializeField] Transform secondsPivot;

    private void Update()
    {
        TimeSpan time = DateTime.Now.TimeOfDay;

        hoursPivot.localRotation = Quaternion.Euler(0, 0, HOURSTODEGREES * (float)time.TotalHours);
        minutesPivot.localRotation = Quaternion.Euler(0, 0, MINUTESTODEGREES * (float)time.TotalMinutes);
        secondsPivot.localRotation = Quaternion.Euler(0, 0, SECONDSTODEGREES * (float)time.TotalSeconds);

    }
}