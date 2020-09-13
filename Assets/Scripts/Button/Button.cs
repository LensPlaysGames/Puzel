using System.Collections;
using System.Collections.Generic;
using U_Puzel;
using UnityEngine;

public class Button : MonoBehaviour, IInteractOnCollide
{
    public bool pressed;

    public delegate void ButtonPressed();
    public ButtonPressed buttonPressed;

    public void OnCollisionEnter2D(Collision2D collider)
    {
        pressed = true;
        buttonPressed?.Invoke();
    }

    public void OnCollisionExit2D(Collision2D collider)
    {
        pressed = false;
    }
}
