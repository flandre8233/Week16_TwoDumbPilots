//DS4.cs
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Utilities;

public class CameraControll : MonoBehaviour
{
    [SerializeField] float MinElevation;
    [SerializeField] float MaxElevation;

    float Elevation;
    float Polar;

    [SerializeField] SphericalCoordinate SphericalCoordinate;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 Stick = Gamepad.all[0].rightStick.ReadValue() + Gamepad.all[1].rightStick.ReadValue();
        Elevation = Stick.y;
        Polar = Stick.x;
        SphericalCoordinate.PolarDegrees += Polar;
        SphericalCoordinate.ElevationDrgrees += -Elevation;
    }
}
