//DS4.cs
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Utilities;


public class StartListener : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (IsReady(0) && IsReady(1))
        {
            OnNextCanvas();
        }
    }

    void OnNextCanvas()
    {
        StatusControll.ToNewStatus(new GameStatus());
    }

    bool IsReady(int ConnectID)
    {
        if ((Gamepad.all.Count > ConnectID))
        {
            return Gamepad.all[ConnectID].leftTrigger.ReadValue() + Gamepad.all[ConnectID].rightTrigger.ReadValue() >= 1.5f;
        }
        return false;
    }
}
