using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField] private GameObject _gameOverCanvas;
    [SerializeField] private GameObject _scoreCanvas;

    private void Start() {
        if (instance == null) {
            instance = this;
        }

        Time.timeScale = 1f;
    }

    public void GameOver() {
        _scoreCanvas.SetActive(false);
        _gameOverCanvas.SetActive(true);
        Time.timeScale = 0f;
    }

    public void RestartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
