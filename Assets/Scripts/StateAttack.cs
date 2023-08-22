﻿using UnityEngine;

namespace Heyipomoea.TwoD
{
    public class StateAttack : State
    {
        [SerializeField, Header("送出攻擊檢測的時間點"), Range(0, 5)]
        private float timeSendAttackCheck = 0.5f;
        [SerializeField, Header("攻擊結束的時間點"), Range(0, 5)]
        private float timeAttackEnd = 1.5f;

        private string parAttack = "觸發攻擊";
        private float timer;

        public override State RunCurrentState()
        {
            if(timer == 0)
            {
                ani.SetTrigger(parAttack);
            }
            else
            {

            }

            timer += Time.deltaTime;

            return this;
        }
    }
}

