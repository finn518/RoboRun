using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public void Setup()
    {
        gameObject.SetActive(true);
    }

    public void RestartBtn()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Game");
    }
}
