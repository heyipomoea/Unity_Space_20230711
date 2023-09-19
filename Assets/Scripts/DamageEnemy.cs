using UnityEngine;


namespace Heyipomoea.TwoD
{
    public class DamageEnemy : DamageSystem
    {
        private string nameBullet = "子彈";

        private void OnCollisionEnter2D(Collision2D collision)
        {
            //print($"碰到的物件: {collision.gameObject}");
            if(collision.gameObject.name.Contains(nameBullet))
            {
                float bulletAttack = collision.gameObject.GetComponent<Bullet>().dataPlayer.attack;
                Damage(bulletAttack);
                Destroy(collision.gameObject);
            }
        }
    }
}

