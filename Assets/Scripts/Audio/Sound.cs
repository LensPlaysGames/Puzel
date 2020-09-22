using System;
using UnityEngine;
using UnityEngine.Audio;

namespace LensorRadii.U_Puzel
{
    [Serializable]
    public class Sound
    {
        public string name;
        public AudioClip clip;
        [Space]
        public AudioMixerGroup mixerGroup;
        [Space]
        [Range(0f, 1f)]
        public float volume;
        [Range(0.1f, 3f)]
        public float pitch;
        [Space]
        public bool loop;
        [Space]
        [HideInInspector]
        public AudioSource source;
    }
}

