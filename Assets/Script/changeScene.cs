using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{
    public void change_button() //change_button�Ƃ������O�ɂ��܂�
    {
        SceneManager.LoadScene("StageTsukuri");//second���Ăяo���܂�
    }
}
