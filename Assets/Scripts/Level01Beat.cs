using System.Collections.Generic;
using UnityEngine;

namespace LensorRadii.U_Puzel
{
    public class Level01Beat : MonoBehaviour, ILevelBeat
    {
        private void Start()
        {
            SubscribeToLM();
        }

        public List<GameObject> doors;

        public void OnLevelBeat(bool b)
        {
            if (b) { OpenDoors(); }
            else { CloseDoors(); }
        }

        private void OpenDoors()
        {
            LevelAudioManager.instance.PlaySound("DoorOpen");

            for (int d = 0; d < doors.Count; d++)
            {
                doors[d].GetComponent<Animator>().Play("Open");
            }
        }

        private void CloseDoors()
        {
            for (int d = 0; d < doors.Count; d++)
            {
                doors[d].GetComponent<Animator>().Play("Close");
            }
        }

        public void SubscribeToLM()
        {
            LevelManager LM = FindObjectOfType<LevelManager>();
            LM.beatLevel += OnLevelBeat;
        }
    }

}