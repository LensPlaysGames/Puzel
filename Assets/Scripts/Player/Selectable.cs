using System.Collections.Generic;
using UnityEngine;

namespace LensorRadii.U_Puzel
{
    public class Selectable : MonoBehaviour
    {
        public string selectID;
        public List<Behaviour> toggles;

        public void Toggle(bool onOff)
        {
            for (int t = 0; t < toggles.Count; t++)
            {
                toggles[t].enabled = onOff;
            }
        }
    }
}
