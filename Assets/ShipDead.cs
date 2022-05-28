using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipDead : MonoBehaviour
{
    Vector3[] RecordPosition = new Vector3[2];

    Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        RecordPosition[0] = transform.position;
    }

    private void FixedUpdate()
    {
        RecordPosition[1] = RecordPosition[0];
        RecordPosition[0] = transform.position;
    }


    private void OnCollisionEnter(Collision other)
    {
        float RealSpeed = (RecordPosition[0] - RecordPosition[1]).magnitude / Time.deltaTime;

        if (RealSpeed > 2)
        {
            //Dead
            ResourcesSpawner.Spawn("EXP", transform.position, 5f);
            ExpShake.instance.SetShake();
            StatusControll.ToNewStatus(new GameoverStatus());
        }

    }
}
