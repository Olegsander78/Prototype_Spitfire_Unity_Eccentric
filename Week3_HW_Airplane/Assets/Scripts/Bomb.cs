using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{

    public GameObject DieEffectPrefab;
    public GameObject DieEffectBulletPrefab;
    
    public GameObject SoundExpBomb;
    
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 1f, 0f);
        //transform.position -= transform.position + Vector3.up;
    }

    public void ExpBomb()
    {
        Destroy(Instantiate(SoundExpBomb), 2f);
        Instantiate(DieEffectPrefab, transform.position, Quaternion.identity);        
        Destroy(gameObject);
    }
    public void ExpBombBullet()
    {
        Destroy(Instantiate(SoundExpBomb), 2f);
        Instantiate(DieEffectBulletPrefab, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
