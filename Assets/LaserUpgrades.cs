using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserUpgrades : MonoBehaviour
{
    public int upgrades = 0;
    public GameObject turret1;
    public GameObject turret2;
    public GameObject turret3;
    public GameObject turret4;
    void Start()
    {

    }

    void Update()
    {
        switch (upgrades)
        {
            case 1:
                turret1.SetActive(false);
                turret2.SetActive(true);
                break;
            case 2:
                turret1.SetActive(false);
                turret2.SetActive(false);
                turret3.SetActive(true);
                break;
            case 3:
                turret1.SetActive(false);
                turret2.SetActive(false);
                turret3.SetActive(false);
                turret4.SetActive(true);
                break;
        }
    }

    public void alteraUpgrades(int valor)
    {
        upgrades += valor;
    }
}
