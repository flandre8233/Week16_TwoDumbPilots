using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpShake : SingletonMonoBehavior<ExpShake>
{
    [SerializeField] Shake shake;

    public void SetShake()
    {
        shake.StartShake(1.25f, 0.5f);
    }
}
