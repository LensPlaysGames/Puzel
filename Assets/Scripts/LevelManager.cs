using UnityEngine;

namespace U_Puzel
{
    [RequireComponent(typeof(ILevelConditions))]
    public class LevelManager : MonoBehaviour
    {
        private bool levelBeat = false;

        public delegate void LevelEvent(bool b);
        public LevelEvent beatLevel;

        private void Start()
        {
            GetComponent<ILevelConditions>().levelConditionsMet += LevelBeat;
        }

        void LevelBeat(bool b)
        {
            if (!levelBeat)
            {
                if (b)
                {
                    beatLevel?.Invoke(true);
                    levelBeat = true;
                }
            }
            else if (levelBeat)
            {
                if (!b)
                {
                    beatLevel?.Invoke(false);
                    levelBeat = false;
                }
            }
        }
    }
}