using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followRotation : MonoBehaviour
{
    [SerializeField] GameObject Main;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Main.transform.rotation;
    }
}
