using UnityEngine;

namespace GameFPS
{
    public class DataRegime : ScriptableObject
    {
        public ERegime typeRegime;
        public int setMaxPlayer = 8;
        public int setMinPlayer = 2;
        public string password = "";
    }
}

