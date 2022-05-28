using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSkip : MonoBehaviour
{
    private void OnEnable()
    {
        Invoke("ToGameStatus", 0.2f);
    }



    void ToGameStatus()
    {
        StatusControll.ToNewStatus(new GameStatus());
    }

}
