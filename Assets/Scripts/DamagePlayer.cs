using Fungus;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Heyipomoea.TwoD
{
    public class DamagePlayer : DamageSystem
    {
        [SerializeField, Header("血條")]
        private Image imgHp;
        [SerializeField, Header("遊戲管理器")]
        protected Flowchart fungusGM;
        [SerializeField, Header("受傷著色器材質球")]
        private Material mHurt;

        private void OnEnable()
        {
            mHurt.SetFloat("_Hurt", 0);
        }
        private void OnDisable()
        {
            mHurt.SetFloat("_Hurt", 0);
        }

        public override void Damage(float getDamage)
        {
            base.Damage(getDamage);

            imgHp.fillAmount = hp / hpMax;

            StartCoroutine(DamageEffect());
            AudioClip sound = SoundManager.instance.soundPlayerHit;
            SoundManager.instance.PlaySound(sound, 0.7f, 1.7f);
        }

        protected override void Dead()
        {
            fungusGM.SendFungusMessage("遊戲失敗");
            Destroy(gameObject);

            AudioClip sound = SoundManager.instance.soundPlayerDead;
            SoundManager.instance.PlaySound(sound, 0.7f, 1.7f);

            AudioClip soundLose = SoundManager.instance.soundLose;
            SoundManager.instance.PlaySound(soundLose, 1.5f, 1.7f);
        }

        private IEnumerator DamageEffect()
        {
            for(int i=0; i<5; i++)
            {
                mHurt.SetFloat("_Hurt", 0.3f);
                yield return new WaitForSeconds(0.1f);
                mHurt.SetFloat("_Hurt", 0);
                yield return new WaitForSeconds(0.1f);
            }
        }
    }
}
