using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    public GameObject DieEffectPrefab;
    public AudioSource Bang;
    void Update()
    {
        transform.Rotate(0f, 1f, 0f);
        //transform.position -= transform.position + Vector3.up;
    }

    public void ExpRocket()
    {
        Instantiate(DieEffectPrefab, transform.position, Quaternion.identity);
        Bang.Play();
        Destroy(gameObject);
    }
}
