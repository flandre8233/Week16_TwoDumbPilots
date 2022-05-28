using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllThrusterShake : MonoBehaviour
{
    [SerializeField] ThrustersShake[] shakes;
    void Update()
    {
        float TotalForce = 0;
        foreach (var item in shakes)
        {
            TotalForce += item.Force;
        }
        TotalForce /= 4f;
        ShakeControll.CameraStart(999, TotalForce);
    }
}
