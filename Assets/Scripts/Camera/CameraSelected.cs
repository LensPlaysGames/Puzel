using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace LensorRadii.U_Puzel
{
    public class CameraSelected : MonoBehaviour
    {
        public List<CamSelectable> cameras;

        private void Awake()
        {
            cameras = FindObjectsOfType<CamSelectable>().ToList();
        }

        private void Start()
        {
            if (SelectionInput.instance != null)
            {
                SelectionInput.instance.selectionChangedEvent += CameraSelect;
            }
        }

        void CameraSelect(string selectID)
        {
            toggle(cameras, selectID);
        }

        public void toggle(List<CamSelectable> selectables, string selectID)
        {
            for (int p = 0; p < selectables.Count; p++)
            {
                if (selectables[p].selectID == selectID)
                {
                    selectables[p].Toggle(true);
                }
                else
                {
                    selectables[p].Toggle(false);
                }
            }
        }
    }
}