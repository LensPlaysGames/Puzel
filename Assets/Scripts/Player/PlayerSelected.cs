using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace LensorRadii.U_Puzel
{
    public class PlayerSelected : MonoBehaviour
    {
        List<Selectable> players;

        private void Awake()
        {
            players = FindObjectsOfType<Selectable>().ToList();

            // Subscribe to Selection Input Event
            if (SelectionInput.instance != null)
            {
                SelectionInput.instance.selectionChangedEvent += SelectPlayer;
            }
        }

        public void FindPlayers()
        {
            players = FindObjectsOfType<Selectable>().ToList();
        }
        public void SelectPlayer(string selectID)
        {
            toggle(players, selectID);
        }

        public void toggle(List<Selectable> selectables, string selectID)
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