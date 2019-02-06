using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool game = true;
    public bool wincond = false;
    public GameObject finishUI;

    public void CompleteLevel()
    {
        wincond = true;
        finishUI.SetActive(true);
    }

    public void GameOver()
    {
        if (game)
        {
            game = false;
            Restart();
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
