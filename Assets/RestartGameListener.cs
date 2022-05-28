//DS4.cs
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Utilities;

public class RestartGameListener : MonoBehaviour
{

    void OnRestartGame()
    {
        gameObject.AddComponent<RestartGame>();
    }
    void Update()
    {
        if (IsReady(0) && IsReady(1))
        {
            OnRestartGame();
        }
    }

    bool IsReady(int ConnectID)
    {
        if ((Gamepad.all.Count > ConnectID))
        {
            return Gamepad.all[ConnectID].startButton.IsPressed() && Gamepad.all[ConnectID].startButton.IsPressed();
        }
        return false;
    }

}
