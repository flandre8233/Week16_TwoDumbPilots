using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall03Move : MonoBehaviour
{
    [SerializeField] float HighestPositionY;
    [SerializeField] float LowestPositionY;

    bool IsUp = false;

    void Update()
    {
        if(IsUp)
        {
            transform.position += Vector3.up * Time.deltaTime;
        }
        else
        {
            transform.position += -Vector3.up * Time.deltaTime;
        }

        if(transform.position.y < LowestPositionY)
        {
            IsUp = true;
        }
        else if(transform.position.y > HighestPositionY)
        {
            IsUp = false;
        }
    }
}
