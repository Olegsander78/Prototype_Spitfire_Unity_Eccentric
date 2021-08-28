using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spitfire : MonoBehaviour
{    
    public Score Score;
    public Health HealthScore;
    public GeneratorCoin GeneratorCoin;
    private void OnTriggerEnter(Collider other)
    {
        Bomb bomb = other.gameObject.GetComponent<Bomb>();
        if (bomb)
        {            
            if (HealthScore.RemoveOneHealth() <= 0)
            {
                Destroy(gameObject);
            }
            bomb.ExpBomb();
        }
        Rocket rocket = other.gameObject.GetComponent<Rocket>();
        if (rocket)
        {            
            if (HealthScore.RemoveOneHealth() <= 0)
            {
                Destroy(gameObject);
            }
            rocket.ExpRocket();
        }
        Coin coin = other.gameObject.GetComponent<Coin>();
        if (coin)
        {
            GeneratorCoin.CollectCoin(coin);
            Score.AddOne();
        }
    }
}
