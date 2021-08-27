using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenRockets : MonoBehaviour
{
    [Header("Set in Inspector")]     
    public GameObject RocketPrefab;    
    public float SecBetweenRocket;

    // Start is called before the first frame update
    void Start()
    {        
        Invoke(nameof(DropRocket), 5f);
        Invoke(nameof(DropRocket), 5.2f);        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    void DropRocket()
    {
        GameObject newRocket = Instantiate(RocketPrefab, transform.position, Quaternion.identity, transform);
        Invoke(nameof(DropRocket), SecBetweenRocket);
    }
}
