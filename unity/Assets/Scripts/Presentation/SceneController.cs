
using UnityEngine;
using static OVRAnchor;

public class SceneController : MonoBehaviour
{
    public void LoadMainMenu()
    {
        LoadScene("MainMenu");
    }

    public void LoadLevelSelector()
    {
        LoadScene("LevelSelector");
    }

    public void LoadOptions()
    {
        LoadScene("Options");
    }

    public void LoadGame()
    {
        LoadScene("GameScene");
    }

    public void LoadResult()
    {
        LoadScene("ResultScreen");
    }

    public void LoadCredits()
    {
        LoadScene("Credits");
    }

    public void RestartGame()
    {
        LoadGame();
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    private void LoadScene(string sceneName)
    {
        Time.timeScale = 1f;

        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }

    public void CompleteLevel()
    {
        GameResult.WasSuccessful = true;
        LoadResult();
    }

    public void FailLevel()
    {
        GameResult.WasSuccessful = false;
        LoadResult();
    }

}
