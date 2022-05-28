using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TotalTimerShowText : CommonUIText
{
    public override void UpdateText()
    {
        text.text = "Total Time : " + Timer.instance.GetTimeString();
    }
}
