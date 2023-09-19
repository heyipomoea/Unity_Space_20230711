using System;
using UnityEngine;


namespace heyipomoea.SceneManager
{
    /// <summary>
    /// 場景管理器:切換場景, 退出遊戲
    /// </summary>
    public class SceneManager : MonoBehaviour
    {
        [SerializeField, Range(0.3f, 3.5f), Header("音效時間")]
        private float soundDuration = 3.0f;
        private string nameSceneToChang;

        /// <summary>
        /// 透過字串切換場景
        /// </summary>
        /// <param name="nameScene">場景名稱</param>
        public void ChangScene(string nameScene)
        {
            nameSceneToChang = nameScene;
            Invoke("DelayChangScene", soundDuration);
        }

        public void DelayChangScene()
        {
            print("切換遊戲");
            UnityEngine.SceneManagement.SceneManager.LoadScene(nameSceneToChang);
        }

        /// <summary>
        /// 離開遊戲
        /// </summary>
        public void Quit()
        {
            Invoke("DelayQuit", soundDuration);
        }

        public void DelayQuit()
        {
            print("離開遊戲");
            Application.Quit();
        }
    }
}
