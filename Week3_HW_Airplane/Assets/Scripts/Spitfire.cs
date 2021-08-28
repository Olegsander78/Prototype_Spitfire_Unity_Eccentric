using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spitfire : MonoBehaviour
{    
    public Score Score;
    public Health HealthScore;
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
            coin.PickUpCoin();
            Score.AddOne();
        }
    }
}
