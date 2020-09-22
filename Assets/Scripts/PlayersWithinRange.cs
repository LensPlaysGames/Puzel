using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace LensorRadii.U_Puzel
{
    public class PlayersWithinRange : MonoBehaviour, IInteractOnCollide
    {
        public Action<bool> valid;

        public List<string> validSelectIDs;

        private bool allWithinRange;
        private List<bool> playersWithinRange = new List<bool>();
        private void Awake()
        {
            for (int s = 0; s < validSelectIDs.Count; s++)
            {
                playersWithinRange.Add(false);
            }
        }

        private void FixedUpdate() // Send Event if All validSelectIds are within range
        {
            if (!allWithinRange)
            {
                if (playersWithinRange.All(x => x == true))
                {
                    valid?.Invoke(true);
                    allWithinRange = true;
                }
                else
                {
                    valid?.Invoke(false);
                    allWithinRange = false;
                }
            }
            else
            {
                if (!playersWithinRange.All(x => x == true))
                {
                    valid?.Invoke(false);
                    allWithinRange = false;
                }
            }
        }
        public void OnTriggerEnter2D(Collider2D collision) // Check Collider selectId against all validSelectIds, Add if Matching
        {
            for (int p = 0; p < validSelectIDs.Count; p++)
            {
                if (collision.gameObject.GetComponent<Selectable>().selectID == validSelectIDs[p])
                {
                    playersWithinRange[p] = true;
                }
            }
        }
        private void OnTriggerExit2D(Collider2D collision)// Check Collider selectId against all validSelectIds, Remove if Matching
        {
            for (int p = 0; p < validSelectIDs.Count; p++)
            {
                if (collision.gameObject.GetComponent<Selectable>().selectID == validSelectIDs[p])
                {
                    playersWithinRange[p] = false;
                }
            }
        }

        #region Not Implemented from IInteractOnCollide
        public void OnCollisionEnter2D(Collision2D collider) { return; }
        public void OnCollisionExit2D(Collision2D collider) { return; }
        #endregion
    }
}