using System;
using UnityEngine;

namespace NickKhalow.Sound_Managments.Scripts
{


    [RequireComponent(typeof(AudioSource))]
    public class ExampleAudio : MonoBehaviour
    {
        [SerializeField] private AudioSource audioSource;
        [SerializeField] private AudioClip[] clips = Array.Empty<AudioClip>();

        private void Start()
        {
            if (audioSource == null)
            {
                audioSource = GetComponent<AudioSource>();
            }
        }

        [ContextMenu(nameof(SimplePlay))]
        public void SimplePlay()
        {
            audioSource.Play();
        }

        [ContextMenu(nameof(Toggle))]
        public void Toggle()
        {
            if (audioSource.isPlaying)
            {
                audioSource.Pause();
            }
            else
            {
                audioSource.Play();
            }
        }

        [ContextMenu(nameof(PlayRandom))]
        public void PlayRandom()
        {
            audioSource.PlayOneShot(clips.Random());
        }
    }
}