//DS4.cs
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Utilities;

public  class DS4ControllData 
{
    // Gyroscope
    public  ButtonControl gyroX = null;
    public  ButtonControl gyroY = null;
    public  ButtonControl gyroZ = null;

    private  void bindControls(Gamepad ds4)
    {
        gyroX = ds4.GetChildControl<ButtonControl>("gyro X 14");
        gyroY = ds4.GetChildControl<ButtonControl>("gyro Y 16");
        gyroZ = ds4.GetChildControl<ButtonControl>("gyro Z 18");
    }

    public  Quaternion getRotation(float scale = 1)
    {
        float x = processRawData(gyroX.ReadValue()) * scale;
        float y = processRawData(gyroY.ReadValue()) * scale;
        float z = -processRawData(gyroZ.ReadValue()) * scale;
        return Quaternion.Euler(x, y, z);
    }

    private  float processRawData(float data)
    {
        return data > 0.5 ? 1 - data : -data;
    }
}
