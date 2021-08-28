using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    [SerializeField]
    private Transform _target;
    public GameObject DieEffectPrefab;
    public GameObject SoundExpRocket;
    public float SpeedRateRocket = 0.15f;
    private float _timer;
    public float TimeLiveRocket = 30f;

    private void Start()
    {
        _target = FindObjectOfType<Spitfire>().gameObject.transform;
    }

    void Update()
    {
        _timer += Time.deltaTime;
        if (_timer > TimeLiveRocket)
        {
            _timer = 0f;
            ExpRocket();
        }
        
        //Вращение ракеты вокруг своей оси
        //transform.Rotate(0f, 0f, 1f);

        //Преследование ракетой игрока
        Vector3 toTarget = _target.position - transform.position;
        //Vector3 toTargetXZ = new Vector3(toTarget.x, 0f, toTarget.z);
        transform.rotation = Quaternion.LookRotation(toTarget);

        transform.position = Vector3.MoveTowards(transform.position, _target.position, Time.deltaTime * SpeedRateRocket);        
    }

    public void ExpRocket()
    {
        Destroy(Instantiate(SoundExpRocket), 2f);
        Instantiate(DieEffectPrefab, transform.position, Quaternion.identity);        
        Destroy(gameObject);
    }
}
