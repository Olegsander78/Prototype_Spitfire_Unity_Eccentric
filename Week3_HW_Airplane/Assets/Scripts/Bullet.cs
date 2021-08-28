using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Bomb bomb = other.gameObject.GetComponent<Bomb>();
        if (bomb)
        {
            Destroy(gameObject);
            bomb.ExpBombBullet();
        }
        Rocket rocket = other.gameObject.GetComponent<Rocket>();
        if (rocket)
        {
            Destroy(gameObject);
            rocket.ExpRocket();
        }
    }
}
