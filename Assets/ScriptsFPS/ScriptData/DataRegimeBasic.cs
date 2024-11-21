using System.Collections.Generic;
using UnityEngine;

namespace GameFPS
{
    [CreateAssetMenu(menuName = "GameFPS/RegimeBasic", fileName = "DataRegimeBasic", order = 3)]
    public class DataRegimeBasic : DataRegime
    {
        public List<int> kills = new List<int>();
    }
}