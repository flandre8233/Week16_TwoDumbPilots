using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Timer : SingletonMonoBehavior<Timer>
{
    float CurTimer;
    void Update()
    {
        CurTimer += Time.deltaTime;
    }

    public string GetTimeString()
    {
        TimeSpan time = TimeSpan.FromSeconds(CurTimer);
        Console.WriteLine(time.ToString("hh':'mm':'ss"));
        return time.ToString("mm':'ss");
    }
}
