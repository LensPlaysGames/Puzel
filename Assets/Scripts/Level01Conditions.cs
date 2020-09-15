using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace U_Puzel
{
    public class Level01Conditions : MonoBehaviour, ILevelConditions
    {
        public List<bool> buttons;
        public bool door;

        private void Start()
        {
            Button[] b = FindObjectsOfType<Button>();
            for (int btn = 0; btn < b.Length; btn++)
            {
                b[btn].SetButtonNumber(btn);
                b[btn].buttonEvent += SetButton;
                buttons.Add(b[btn].pressed);
            }

            FindObjectOfType<PlayersWithinRange>().valid += SetDoor;
        }

        public bool ifLevelConditionsMet { get; set; }
        public Action<bool> levelConditionsMet { get; set; }

        private void FixedUpdate()
        {
            if (buttons.All(x => x == true) && door) { ifLevelConditionsMet = true; }
            else { ifLevelConditionsMet = false; }

            levelConditionsMet?.Invoke(ifLevelConditionsMet);
        }

        void SetButton(int buttonIndex, bool buttonState)
        {
            buttons[buttonIndex] = buttonState;
        }

        void SetDoor(bool valid)
        {
            door = valid;
        }
    }
}