using System;
using UnityEngine;


namespace heyipomoea
{
    /// <summary>
    /// 場景管理器:切換場景, 退出遊戲
    /// </summary>
    public class SceneManager : MonoBehaviour
    {
        public void ChangScene()
        {
            print("切換遊戲");
            UnityEngine.SceneManagement.SceneManager.LoadScene("遊戲場景");
        }

       

        public void Quit()
        {
            print("離開遊戲");
            Application.Quit();
        }
    }
}
