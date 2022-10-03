using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenu : MonoBehaviour
{
    public int money;
    public int earnedMoney;
    public TextMeshProUGUI moneyText;

    public void Start() {
        money = PlayerPrefs.GetInt("Money");
        earnedMoney = PlayerPrefs.GetInt("Score");
        money += earnedMoney;
        PlayerPrefs.SetInt("Money", money);
        moneyText.text = "Money: " + money.ToString();
        earnedMoney = 0;
        PlayerPrefs.SetInt("Score", earnedMoney);
    }
    
    public void StartGame()
    {
        SceneManager.LoadScene(((byte)Scenes.ScenesEnum.Game));
    }

    public void OpenShop()
    {
        SceneManager.LoadScene(((byte)Scenes.ScenesEnum.Shop));
    }
}
