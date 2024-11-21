using UnityEngine;

namespace GameFPS
{
    public class DataWeapon : ScriptableObject
    {
        public EWeapon typeWeapon;
        public string nameWeapon;
        public float damage;
        public GameObject weaponPrefab;
        public AudioClip clipShot;
    }
}

