using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrustersForce : MonoBehaviour
{
    [SerializeField] int GamePadCh;
    Thrusters thrusters;

    void Start()
    {
        thrusters = GetComponent<Thrusters>();
    }

    private void Update()
    {
        thrusters.SetForec(GetForce());
    }

    public float GetForce()
    {
        if (!StatusControll.instance.IsStatusEqual(new GameStatus()))
        {
            return 0;
        }
        return ((GamePadController.instance.GetGamepad(GamePadCh).leftTrigger.ReadValue()) + (GamePadController.instance.GetGamepad(GamePadCh).rightTrigger.ReadValue())) / 2;
    }
}
