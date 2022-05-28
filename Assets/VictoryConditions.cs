using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryConditions : MonoBehaviour
{
    [SerializeField] float StayTime;

    [SerializeField] bool IsTiming;
    void Start()
    {
        StayTime = 0;
        IsTiming = false;
    }


    void Update()
    {
        if (IsTiming)
        {
            StayTime += Time.deltaTime;
        }
        if (StayTime > 3)
        {
            //Win
            StatusControll.ToNewStatus(new GameoverStatus());
            WinLose.instance.Result = true;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        IsTiming = true;
    }

    private void OnCollisionExit(Collision other)
    {
        IsTiming = false;
        StayTime = 0;
    }
}
