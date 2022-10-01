using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class BallScripts : MonoBehaviour
{
  public int score = 0;
  [SerializeField] TextMeshProUGUI scoreText;

  private void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.gameObject.tag == "Enemy") {
      SceneManager.LoadScene(((byte)Scenes.ScenesEnum.Lose));
      PlayerPrefs.SetInt("Score", score);
    }
    if (collision.gameObject.tag == "Bonus")
      score++;
    Destroy(collision.gameObject);
  }

  void Update()
  {
    scoreText.text = score.ToString();
  }
}
