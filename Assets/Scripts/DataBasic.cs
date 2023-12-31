﻿using UnityEngine;


namespace Heyipomoea.TwoD
{
    [CreateAssetMenu(menuName ="Heyipomoea/DataBasic", fileName ="Data Basic")]
    public class DataBasic : ScriptableObject
    {
        [Header("血量"), Range(0, 1500)]
        public float hp = 100;
        [Header("攻擊力"), Range(0, 1000)]
        public float attack = 30;
    }
}
