//InputTest.cs
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class ThrustersRotate : MonoBehaviour
{
    [SerializeField] int GamePadCh;

    private Gamepad controller = null;
    private Transform m_transform;

    void Start()
    {
        controller = GetGamepad();
        print(controller.buttonSouth.isPressed);
        print(controller.buttonEast.isPressed);

        m_transform = this.transform;
    }

    void Update()
    {
        //Press circle button to reset rotation
        if (controller.buttonEast.isPressed)
        {
            transform.localRotation = Quaternion.identity;
        }

        transform.localRotation *= GetRotationData();

        //transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, 0, 0);
        //GetComponent<Thrusters>().ShipRotation *= DS401.getRotation(4000 * Time.deltaTime);
    }

    Quaternion GetRotationData()
    {
        Quaternion DS4RotationData = GamePadController.instance.getRotation( GamePadCh , 4000 * Time.deltaTime);
        return DS4RotationData;
    }

    Gamepad GetGamepad()
    {
        return GamePadController.instance.GetGamepad(GamePadCh);
    }
}
