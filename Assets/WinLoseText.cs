using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLoseText : CommonUIText
{
    protected override void Start()
    {
        base.Start();
        UpdateText();
    }
    public override void UpdateText()
    {
        text.text = WinLose.instance.Result ? "You WIN!!" : "Lost Signal...";
    }
}
