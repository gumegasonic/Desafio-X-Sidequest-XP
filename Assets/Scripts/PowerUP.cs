using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUP : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Upgrades>().alteraUpgrades(1);
            collision.gameObject.GetComponent<LaserUpgrades>().alteraUpgrades(1);
            Destroy(this.gameObject);
        }
    }
}
