//DS4.cs
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Utilities;

public class GamePadController : SingletonMonoBehavior<GamePadController>
{

    private void Start()
    {
        RegisterLayout();

        Invoke("Test" , 1f);
    }

    void RegisterLayout()
    {
        string layout = File.ReadAllText("Assets/Script/customLayout01.json");
        InputSystem.RegisterLayoutOverride(layout, "DualShock4GamepadHID");
    }

    void Test()
    {
        print(GetGamepad(0).name);
        print(Gamepad.current.leftTrigger.ReadValue());
        print(GetGamepad(0).leftTrigger);
        print(GetGamepad(0).leftTrigger.ReadValue());
    }

    private void Update()
    {
        //print(getRotation(0 , 1 ).eulerAngles);
    }

    public Gamepad GetGamepad(int Index)
    {
        return Gamepad.all[Index];
    }

    public Quaternion getRotation(int Index , float Scale)
    {
        Gamepad ds4 = GetGamepad(Index);
        float x = processRawData(ds4.GetChildControl<ButtonControl>("gyro X 14").ReadValue()) * Scale;
        float y = processRawData(ds4.GetChildControl<ButtonControl>("gyro Y 16").ReadValue()) * Scale;
        float z = -processRawData(ds4.GetChildControl<ButtonControl>("gyro Z 18").ReadValue()) * Scale;
        return Quaternion.Euler(x, y, z);
    }

    private float processRawData(float data)
    {
        return data > 0.5 ? 1 - data : -data;
    }
}
