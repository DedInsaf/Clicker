using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] int money;
    public Text moneyText;
    public int total_money;

    public void ButtonClick()
    {
        money++;
        total_money++;
        PlayerPrefs.SetInt("money", money);
        PlayerPrefs.SetInt("total_money", total_money);
    }

    void Start()
    {
        money = PlayerPrefs.GetInt("money");
        total_money = PlayerPrefs.GetInt("total_money");
    }

    void Update()
    {
        moneyText.text = money.ToString();
    }

    public void ToAchievements()
    {
        SceneManager.LoadScene(1);
    }
}
