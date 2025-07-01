using UnityEngine;
using UnityEngine.SceneManagement;

public class change : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
     public void change_button()
    {
        SceneManager.LoadScene("StageTsukuri");
    }
    public void button()
    {
        SceneManager.LoadScene("Title");
    }
}
