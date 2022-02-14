using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ativador : MonoBehaviour
{
    public float timer;
    private float timerAtual;
    public GameObject objectToEnable;
    void Start()
    {
        timerAtual = Time.time + timer;
    }

    void Update()
    {
        if (Time.time >= timerAtual && Time.time <= timerAtual + 0.1f)
        {
            objectToEnable.gameObject.SetActive(true);
        }
    }

}
