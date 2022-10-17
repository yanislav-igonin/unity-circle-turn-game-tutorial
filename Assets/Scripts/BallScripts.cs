using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class BallScripts : MonoBehaviour
{
  public int score = 0;
  [SerializeField] TextMeshProUGUI scoreText;
  public bool isMulti;

  public GameObject bonusEffect;

  private void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.gameObject.tag == "Enemy") {
      SceneManager.LoadScene(((byte)Scenes.ScenesEnum.Lose));
      PlayerPrefs.SetInt("Score", score);
    }
    if (collision.gameObject.tag == "Bonus") {
      score = isMulti ? score + 2 : score + 1;
      Instantiate(bonusEffect, transform.position, Quaternion.identity);
    }
    Destroy(collision.gameObject);
  }

  public void Start()
  {
    isMulti = PlayerPrefs.GetInt("isMultiBought") == 1;
  }

  public void Update()
  {
    scoreText.text = score.ToString();
  }
}
