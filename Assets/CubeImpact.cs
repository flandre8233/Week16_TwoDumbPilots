using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeImpact : MonoBehaviour
{
    [SerializeField]
    Rigidbody Rigidbody;

    private void OnCollisionEnter(Collision other)
    {
        print("magnitude" + Rigidbody.velocity.magnitude);
    }
}
