using System.Collections.Generic;
using UnityEngine;

namespace GameFPS
{
    [CreateAssetMenu(menuName = "GameFPS/RegimeZombie", fileName = "DataRegimeZombie", order = 4)]
    public class DataRegimeZombie : DataRegime
    {
        public float timeCountDown = 12f;
        public float timeRound = 180f;
        public List<int> rounds = new List<int>();
    }
}