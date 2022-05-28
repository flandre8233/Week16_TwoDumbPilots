using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrustersAudio : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;

    [SerializeField] ThrustersForce force;


    // Update is called once per frame
    void Update()
    {
        audioSource.volume = 1 * force.GetForce();
    }
}
