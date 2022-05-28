using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] GameObject Ship;

    [SerializeField] Vector3 offset;
    void Start()
    {
        offset = transform.position - Ship.transform.position;
    }

    void Update()
    {
        transform.position = Ship.transform.position + offset;
    }
}
