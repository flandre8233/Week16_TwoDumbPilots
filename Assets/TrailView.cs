using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailView : MonoBehaviour
{
    [SerializeField] TrailRenderer TrailRenderer;
    [SerializeField] ThrustersForce force;

    private void Update()
    {
        if (force.GetForce() <= 0 )
        {
            TrailRenderer.Clear();
        }

        TrailRenderer.startWidth = 1 * force.GetForce();
    }
}
