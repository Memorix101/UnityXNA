using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Microsoft.Xna.Framework.Media
{
    public static class MediaPlayer
    {
        private static AudioSource audioSource;

        public static AudioSource AudioSource
        {
            set { MediaPlayer.audioSource = value; }
        }

        public static bool IsRepeating
        {
            get
            {
                return audioSource.loop;
            }
            set
            {
                audioSource.loop = value;
            }
        }

        public static float Volume
        {
            get
            {
                return audioSource.volume;
            }
            set
            {
                audioSource.volume = value;
            }
        }

        internal static void Play(Song song)
        {
            audioSource.clip = song.Clip;
            audioSource.volume = Volume;
            audioSource.Play();
        }
    }
}
