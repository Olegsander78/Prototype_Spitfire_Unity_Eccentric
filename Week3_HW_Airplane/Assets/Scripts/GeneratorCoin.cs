using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorCoin : MonoBehaviour
{
    public GameObject CoinPrefab;
    public List<Coin> CoinsList = new List<Coin>();
    public int NumberCoins = 30;
    public AudioSource AudioCoinPickUp;
    //public Text Score;

    // Start is called before the first frame update
    void Start()
    {
        AudioCoinPickUp = GetComponent<AudioSource>();
        GenCoins(NumberCoins);
        //UpdateText();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(0f, (Mathf.Sin(Time.time * 3f) * 0.5f) + 0.5f, 0f);
    }

    void GenCoins(int numbCoins)
    {
        for (int i = 0; i < numbCoins; i++)
        {
            Vector3 positionCoin = new Vector3(Random.Range(-140f, 100f), Random.Range(-30f, 30f),0f);
            GameObject newCoin = Instantiate(CoinPrefab, positionCoin, Quaternion.AngleAxis(90, Vector3.right), transform);
            CoinsList.Add(newCoin.GetComponent<Coin>());
        }
    }

    public void CollectCoin(Coin coin)
    {
        CoinsList.Remove(coin);
        AudioCoinPickUp.Play();
        Destroy(coin.gameObject);
        //UpdateText();
    }

    //void UpdateText()
    //{
    //    Score.text = "Собрано " + (NumberCoins - CoinsList.Count).ToString() + " монет из " + NumberCoins.ToString();
    //}
}
