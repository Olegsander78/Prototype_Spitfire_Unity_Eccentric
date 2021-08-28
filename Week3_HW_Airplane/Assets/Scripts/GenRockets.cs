using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenRockets : MonoBehaviour
{
    [Header("Set in Inspector")]     
    public GameObject RocketPrefab;    
    public float SecBetweenRocket;
    public AudioSource LunchRocket;

    // Start is called before the first frame update
    void Start()
    {        
        Invoke(nameof(DropRocket), 10f);
        Invoke(nameof(DropRocket), 11f);
        Invoke(nameof(DropRocket), 12f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    void DropRocket()
    {
        GameObject newRocket = Instantiate(RocketPrefab, transform.position, Quaternion.identity, transform);
        LunchRocket.Play();
        Invoke(nameof(DropRocket), SecBetweenRocket);
    }
}
