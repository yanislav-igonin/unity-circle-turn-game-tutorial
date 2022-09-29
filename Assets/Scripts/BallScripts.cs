using UnityEngine;
using TMPro;

public class BallScripts : MonoBehaviour
{
  public int score = 0;
  [SerializeField] TextMeshProUGUI scoreText;

  private void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.gameObject.tag == "Enemy")
      score = 0;
    if (collision.gameObject.tag == "Bonus")
      score++;
    Destroy(collision.gameObject);
  }

  void Update()
  {
    scoreText.text = score.ToString();
  }
}
