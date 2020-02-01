using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class FixedButton : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    [HideInInspector]
    public bool Pressed;

    public Action OnBtnDown;

    public void OnPointerDown(PointerEventData eventData)
    {
        Pressed = true;

        OnBtnDown?.Invoke();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Pressed = false;
    }
}