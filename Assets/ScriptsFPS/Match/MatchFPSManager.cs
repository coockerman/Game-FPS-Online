using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameFPS
{
    public abstract class MatchFPSManager : Singleton<MatchFPSManager>
    {
        public enum GameFPSState
        {
            Waiting,
            Playing,
            Ending
        }
    }
}

