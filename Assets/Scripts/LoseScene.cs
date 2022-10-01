using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LoseScene : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreText;

    void Start()
    {
        score = PlayerPrefs.GetInt("Score");
    }

    public void Update()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene(((byte)Scenes.ScenesEnum.MainMenu));
    }
}
