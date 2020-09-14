using System.Collections.Generic;
using UnityEngine;

namespace U_Puzel
{
    public class LevelAudioManager : MonoBehaviour
    {
        #region Singleton/Init

        public static LevelAudioManager instance;
        private void Awake()
        {
            if (instance != null) { UnityEngine.Debug.LogError("MULTIPLE LEVEL AUDIO MANAGERS IN THE SCENE, CLEANING UP THE GARBAGE, SON!"); Destroy(this); }
            else { instance = this; }
        }

        #endregion

        public List<Sound> sounds;
        private void Start()
        {
            for (int s = 0; s < sounds.Count; s++)
            {
                AudioSource src = gameObject.AddComponent<AudioSource>();

                src.outputAudioMixerGroup = sounds[s].mixerGroup;

                src.clip = sounds[s].clip;
                src.volume = sounds[s].volume;
                src.pitch = sounds[s].pitch;
                src.loop = sounds[s].loop;
                src.playOnAwake = false;

                sounds[s].source = src;
            }
        }
        public void PlaySound(string sound)
        {
            Sound snd = sounds.Find(s => s.name == sound);
            if(snd != null) { snd.source.Play(); }
            else { Debug.LogWarning("Sound " + sound + " Was Not Found"); }
        }
    }
}