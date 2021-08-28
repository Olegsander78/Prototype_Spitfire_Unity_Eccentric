using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetRocket : MonoBehaviour
{
    public Transform TargetForRocket;

    // Update is called once per frame
    void Update()
    {
        transform.position = TargetForRocket.position;
    }
}
