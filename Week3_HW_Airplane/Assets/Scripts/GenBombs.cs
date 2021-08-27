using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenBombs : MonoBehaviour
{
    [Header("Set in Inspector")]    
    public GameObject BombPrefab;    
    public float SecBetweenBomb;    

    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(DropBomb), 3f);        
    }

    // Update is called once per frame
    
    void DropBomb()
    {
        GameObject newBomb = Instantiate(BombPrefab, transform.position, Quaternion.identity, transform);
        Invoke(nameof(DropBomb), SecBetweenBomb);
    }
}
