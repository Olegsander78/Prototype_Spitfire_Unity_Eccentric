using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spitfire : MonoBehaviour
{
    public int HealthSpitfire;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Bomb>())
        {
            HealthSpitfire -= 1;
            if (HealthSpitfire <= 0)
            {
                Destroy(gameObject);
            }
            other.gameObject.GetComponent<Bomb>().ExpBomb();
        }
        if (other.gameObject.GetComponent<Rocket>())
        {
            HealthSpitfire -= 1;
            if (HealthSpitfire <= 0)
            {
                Destroy(gameObject);
            }
            other.gameObject.GetComponent<Rocket>().ExpRocket();
        }
    }
}
