using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloqueador : MonoBehaviour
{
    public string tagToDestroy;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag(tagToDestroy))
        {
            Destroy(collision.gameObject);
        }
    }
}
