using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public float HP;
    public float MaxHP = 200;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        HP = MaxHP;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetDamage(30);
        }
    }

    public void GetDamage(float Damage)
    {
        HP -= Damage;
        if (HP <= 0)
        {
            SceneManager.LoadScene("GameOver");
            gameObject.SetActive(false);
        }
    }
}
