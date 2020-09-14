using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace U_Puzel
{
    public class LevelManager : MonoBehaviour
    {
        public List<bool> buttons;
        private bool levelBeat = false;

        public delegate void LevelEvent(bool b);
        public LevelEvent beatLevel;

        private void Start()
        {
            Button[] b = FindObjectsOfType<Button>();
            for (int btn = 0; btn < b.Length; btn++)
            {
                b[btn].SetButtonNumber(btn);
                b[btn].buttonEvent += SetButton;
                buttons.Add(b[btn].pressed);
            }
        }

        private void FixedUpdate()
        {
            if (!levelBeat)
            {
                if (buttons.All(x => x == true))
                {
                    beatLevel?.Invoke(true);
                    levelBeat = true;
                }
            }
            else if (levelBeat)
            {
                if (!buttons.All(x => x == true))
                {
                    beatLevel?.Invoke(false);
                    levelBeat = false;
                } 
            }
        }

        void SetButton(int buttonIndex, bool buttonState)
        {
            buttons[buttonIndex] = buttonState;
        }
    }
}