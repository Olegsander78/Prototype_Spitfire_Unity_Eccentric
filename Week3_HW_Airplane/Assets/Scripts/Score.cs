using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int Coins = 0;
    public Text Coinstext;

    private void Start()
    {
        UpdateText();
    }

    public void AddOne()
    {
        Coins += 1;
        UpdateText();
    }
    void UpdateText()
    {
        Coinstext.text = "Собрано монет: " + Coins.ToString();
    }
}
