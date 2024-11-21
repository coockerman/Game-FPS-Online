using UnityEngine;

namespace GameFPS
{
    [CreateAssetMenu(menuName = "GameFPS/Gun", fileName = "DataGun", order = 0)]
    public class DataGun : DataWeapon
    {
        public bool isAutomatic = false;
        public int maxBullet = 0;
        public float speedShot = 0.2f;
        
    }
}

