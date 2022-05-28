using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrustersShake : MonoBehaviour
{
    [SerializeField] Shake shake;

    [SerializeField] Thrusters Thrusters;

    public float Force;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        Force = Thrusters.Force / 1000f;
        shake.StartShake(999f, Force);
    }
}
