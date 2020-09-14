using System.Collections.Generic;
using UnityEngine;

namespace U_Puzel
{ 
    public class Button : MonoBehaviour, IInteractOnCollide
    {
        public int number;

        public List<string> validSelectIDs;

        public bool pressed;

        public delegate void ButtonPressed(int number, bool state);
        public ButtonPressed buttonEvent;

        public void OnCollisionEnter2D(Collision2D collider)
        {
            for (int s = 0; s < validSelectIDs.Count; s++)
            {
                if (collider.gameObject.GetComponent<Selectable>().selectID == validSelectIDs[s])
                {
                    pressed = true;
                    buttonEvent?.Invoke(number, pressed);
                }
                else
                {
                    pressed = false;
                    buttonEvent?.Invoke(number, pressed);
                    break;
                }
            }
        }

        public void OnCollisionExit2D(Collision2D collider)
        {
            pressed = false;
            buttonEvent?.Invoke(number, pressed);
        }

        public void SetButtonNumber(int buttonNumber)
        {
            number = buttonNumber;
        }
    }
}