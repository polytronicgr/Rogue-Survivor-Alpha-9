﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace djack.RogueSurvivor.Engine
{
    class NullSoundManager : ISoundManager
    {
        #region Properties
        public bool IsMusicEnabled { get; set; }
        public int Volume { get; set; }
        #endregion

        #region Init
        public NullSoundManager() { }
        #endregion

        #region Loading music
        public bool Load(string musicname, string filename) { return true;  }

        public void Unload(string musicname) { }
        #endregion

        #region Playing music

        public void Play(string musicname) { }

        public void PlayIfNotAlreadyPlaying(string musicname) { }

        public void PlayLooping(string musicname) { }

        public void ResumeLooping(string musicname) { }

        public void Stop(string musicname) { }

        public void StopAll() { }

        public bool IsPlaying(string musicname) { return false; }

        public bool IsPaused(string musicname) { return false;  }

        public bool HasEnded(string musicname) { return true;  }
        #endregion

        #region IDisposable
        public void Dispose() { }
        #endregion
    }
}