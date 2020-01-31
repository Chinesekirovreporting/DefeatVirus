using System;
using UnityEngine;

public class ControllerUI : MonoBehaviour
{
    public static Vector2 RunAxis = Vector2.zero;
    public static Vector2 LookAxis = Vector2.zero;
    public static bool FirePressed = false;

    public FixedButton FireBtn;
    public FixedTouchField TouchField;
    public FixedJoystick Joystick;

    private void Update()
    {
        FirePressed = FireBtn.Pressed;
        LookAxis = TouchField.TouchDist;
        RunAxis = new Vector2(Joystick.Horizontal + Input.GetAxis("Horizontal"), Joystick.Vertical + Input.GetAxis("Vertical"));
    }
}
