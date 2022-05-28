using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerShowText : CommonUIText
{
    private void Update()
    {
        UpdateText();
    }
    public override void UpdateText()
    {
        text.text = Timer.instance.GetTimeString();
    }
}
