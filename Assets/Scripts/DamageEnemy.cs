﻿using UnityEngine;


namespace Heyipomoea.TwoD
{
    public class DamageEnemy : DamageSystem
    {
        [SerializeField, Header("狀態管理")]
        private StateManager stateManager;
        [SerializeField, Header("受傷狀態")]
        private StateHit stateHit;

        private string nameBullet = "子彈";

        private void OnCollisionEnter2D(Collision2D collision)
        {
            //print($"碰到的物件: {collision.gameObject}");
            if(collision.gameObject.name.Contains(nameBullet))
            {
                float bulletAttack = collision.gameObject.GetComponent<Bullet>().dataPlayer.attack;
                Damage(bulletAttack);
                Destroy(collision.gameObject);
                stateManager.stateDefault = stateHit;
            }
        }
        protected override void Dead()
        {
            Destroy(gameObject);
        }
    }
}
