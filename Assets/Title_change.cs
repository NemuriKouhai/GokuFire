using UnityEngine;
using UnityEngine.SceneManagement;

public class Title_change : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void change_button()
    {
        SceneManager.LoadScene("Tile");
    }
}
