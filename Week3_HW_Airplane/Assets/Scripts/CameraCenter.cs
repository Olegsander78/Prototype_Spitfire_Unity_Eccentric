using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCenter : MonoBehaviour
{
    public Transform Target;

    // Update is called once per frame
    void Update()
    {
        if (Target)
        {
            transform.position = Target.position;
        }
    }
}
