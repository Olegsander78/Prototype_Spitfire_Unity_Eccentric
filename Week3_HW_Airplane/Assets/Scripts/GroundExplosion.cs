using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundExplosion : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Bomb>())
        {                     
            other.gameObject.GetComponent<Bomb>().ExpBomb();
        }
        if (other.gameObject.GetComponent<Rocket>())
        {
            other.gameObject.GetComponent<Rocket>().ExpRocket();
        }
    }
}
