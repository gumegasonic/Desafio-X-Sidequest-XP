using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float velocity;
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        if (Time.timeScale > 0)
        {
            transform.Translate(0, velocity, 0);
        }
    }
}
