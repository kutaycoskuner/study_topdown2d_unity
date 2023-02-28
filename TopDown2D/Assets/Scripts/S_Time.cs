using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_Time : MonoBehaviour
{
    // ----- events ---------------------------------------------
    public static Action OnMinuteChange;
    public static Action OnHourChange;
    public static Action OnDayPercentChange;

    public static int minute { get; private set; }
    public static int hour { get; private set; }
    public static float dayPercentage = 0.00f;

    private float gameDaysInRealMinutes;
    private float gameMinuteInRealSeconds = 1f;
    private float tick;
    private int hourReset = 24;     //{ get; set; }

    private float dayPercentagePrev = 0.00f;
    const int minuteInDay = 1440;


    // Start is called before the first frame update
    void Start()
    {
        hour = 8;
        minute = 30;
        tick = gameMinuteInRealSeconds;
    }

    // Update is called once per frame
    void Update()
    {
        tick -= Time.deltaTime;
        tickMinute();
        tickHour();
        calcDayPercentage();
    }

    private void tickMinute()
    {
        if (tick > 0) { return; }
        minute += 1;
        OnMinuteChange?.Invoke();
        tick = gameMinuteInRealSeconds;
    }

    private void tickHour()
    {
        if (minute < 60) { return; }
        hour += 1;
        minute = 0;
        OnHourChange?.Invoke();
        if (hour < hourReset) { return; }
        hour = 0;
    }

    private void calcDayPercentage()
    {
        int elapsedMinuteInDay = hour * 60 + minute;
        dayPercentage = (float)elapsedMinuteInDay / (float)minuteInDay;
        if (dayPercentage.ToString("F2") == dayPercentagePrev.ToString("F2")) { return; }
        dayPercentagePrev = dayPercentage;
        OnDayPercentChange?.Invoke();
    }
}
