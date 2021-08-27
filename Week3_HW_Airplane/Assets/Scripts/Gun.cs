using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject BulletPrefab;
    public float BulletSpeed;
    public AudioSource ShotSound;

    public float ShotPeriod = 0.15f;
    private float _timer;

    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;

        if (Input.GetKey(KeyCode.Space))
        {
            if (_timer > ShotPeriod)
            {
                _timer = 0f;
                CreateBullet();                
            }
        }    
    }

    void CreateBullet()
    {
        GameObject newBullet = Instantiate(BulletPrefab, transform.position, transform.rotation, transform);
        newBullet.GetComponent<Rigidbody>().velocity = transform.forward * BulletSpeed;
        ShotSound.pitch = Random.Range(0.5f, 1f);
        ShotSound.Play();
    }
}
