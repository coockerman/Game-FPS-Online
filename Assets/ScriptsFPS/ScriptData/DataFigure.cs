using System.Collections.Generic;
using UnityEngine;

namespace GameFPS
{
    [CreateAssetMenu(menuName = "GameFPS/Figure", fileName = "DataFigure", order = 2)]
    public class DataFigure : ScriptableObject
    {
        public EFigure typeFigure;
        public float maxHealth;
        public float maxDefense;
        public List<Material> materials;
        
    }
}

