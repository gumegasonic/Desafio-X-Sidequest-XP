using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoMouse : MonoBehaviour
{
    public bool workOnPause;
    private Vector3 MouseCoords;
    public float MouseSensitivity = 0.1f;
    void Start()
    {
        
    }

    void Update()
    {
        if (!workOnPause)
        {
            if (Time.timeScale > 0)
            {
                MouseCoords = Input.mousePosition;
                MouseCoords = Camera.main.ScreenToWorldPoint(MouseCoords);
                this.transform.position = Vector2.Lerp(transform.position, MouseCoords, MouseSensitivity);
            }
        }
        else
        {
            MouseCoords = Input.mousePosition;
            MouseCoords = Camera.main.ScreenToWorldPoint(MouseCoords);
            this.transform.position = Vector2.Lerp(transform.position, MouseCoords, MouseSensitivity);
        }
    }
}
