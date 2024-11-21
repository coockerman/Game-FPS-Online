using UnityEngine;

namespace GameFPS
{
    [CreateAssetMenu(menuName = "GameFPS/Knight", fileName = "DataKnight", order = 1)]
    public class DataKnight : DataWeapon
    {
        public float timeShot = 0.5f;
        public float timeDelay = 0.25f;
        
    }
}

