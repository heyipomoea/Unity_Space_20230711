using System;
using UnityEngine;


namespace heyipomoea
{
    /// <summary>
    /// �����޲z��:��������, �h�X�C��
    /// </summary>
    public class SceneManager : MonoBehaviour
    {
        public void ChangScene()
        {
            print("�����C��");
            UnityEngine.SceneManagement.SceneManager.LoadScene("�C������");
        }

       

        public void Quit()
        {
            print("���}�C��");
            Application.Quit();
        }
    }
}
