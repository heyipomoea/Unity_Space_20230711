using UnityEngine;


namespace Heyipomoea.TwoD
{
    /// <summary>
    /// 受傷系統:血量, 受傷方法, 死亡方法
    /// </summary>
    public class DamageSystem : MonoBehaviour
    {
        [SerializeField, Header("資料")]
        private DataBasic data;

        private float hp;
        private float hpMax;

        private void Awake()
        {
            hp = data.hp;
            hpMax = hp;
        }

        /// <summary>
        /// 受傷
        /// </summary>
        /// <param name="getDamage">受到的傷害</param>
        public void Damage(float getDamage)
        {
            hp -= getDamage;

            if (hp <= 0) Dead();
        }

        /// <summary>
        /// 死亡
        /// </summary>
        private void Dead()
        {

        }
    }
}

