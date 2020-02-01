using System;
using UnityEngine;

public class ControllerUI : MonoBehaviour
{
    public static ControllerUI Instance;
    public static Vector2 RunAxis = Vector2.zero;
    public static Vector2 LookAxis = Vector2.zero;
    public static bool FirePressed = false;
    public static bool JumpPressed = false;

    public FixedButton FireBtn;
    public FixedTouchField TouchField;
    public FixedJoystick Joystick;
    public FixedButton JumpBtn;
    public FixedButton SwitchBtn;

    private void Awake()
    {
        Instance = this;

        SwitchBtn.OnBtnDown = OnSwitchDown;
    }

    private void OnSwitchDown()
    {
        Controller.Instance.NextWeapon();
    }

    private void Update()
    {
        FirePressed = FireBtn.Pressed;
        JumpPressed = JumpBtn.Pressed;
        
        LookAxis = TouchField.TouchDist;
        RunAxis = new Vector2(Joystick.Horizontal + Input.GetAxis("Horizontal"), Joystick.Vertical + Input.GetAxis("Vertical"));
        RunAxis *= 2;
    }
}
