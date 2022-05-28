using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thrusters : MonoBehaviour
{
    [SerializeField] Vector3 Direction;
    [SerializeField] Rigidbody RB;

    public float MaxForce = 0.2f;
    public float Force = 1f;

    void Start()
    {
    }

    private void FixedUpdate()
    {
        Direction = transform.up;
        ApplyForce(RB);
    }

    void Update()
    {
        //Direction = transform.up;
        //ApplyForce(RB);
        
        //transform.localRotation = Quaternion.LookRotation(Direction);
        //transform.localRotation = ShipRotation;
    }

    void ApplyForce(Rigidbody body)
    {// a sub function where you pass it a
     //rigidbody and it adds force to it
     //here they are making a vector3 to put in for 1st parameter
     // Vector3 direction = body.transform.position - transform.position;
     //here they call AddForce on the rigidbody
     //rigidbodyVariable.function(         parameter 1   ,      parameter2   );
        body.AddForceAtPosition(Direction.normalized * Force, transform.position);
    }


    public void SetForec(float PlayerForce)
    {
        Force = MaxForce * PlayerForce;
    }
}
