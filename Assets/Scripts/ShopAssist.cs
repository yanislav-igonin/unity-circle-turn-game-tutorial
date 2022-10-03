using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ShopAssist : MonoBehaviour
{
    public int money;
    public TextMeshProUGUI moneyText;

    public bool isMultiBought;

    public Button multiButton;
    
    void Start()
    {
        money = PlayerPrefs.GetInt("Money");
        isMultiBought = PlayerPrefs.GetInt("isMultiBought") == 1;
    }

    // Update is called once per frame
    void Update()
    {
        moneyText.text = "Money: " + money.ToString();
        if (isMultiBought)
        {
            multiButton.interactable = false;
            multiButton.enabled = false;
        }
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(((byte)Scenes.ScenesEnum.MainMenu));
    }

    public void BuyMultiplier(int price)
    {
        if (money >= price && isMultiBought == false)
        {
            money -= price;
            PlayerPrefs.SetInt("Money", money);
            isMultiBought = true;
            PlayerPrefs.SetInt("isMultiBought", isMultiBought ? 1 : 0);
        }
    }
}
