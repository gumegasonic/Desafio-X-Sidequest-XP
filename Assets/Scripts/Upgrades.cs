using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrades : MonoBehaviour
{
    public int upgrades = 0;
    public GameObject turret1;
    public GameObject turret2;
    public GameObject turret3;
    public GameObject turret4;
    public GameObject turret5;
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        switch (upgrades)
        {
            case 1:
                Upgrade1();
                break;
            case 2:
                Upgrade2();
                break;
            case 3:
                Upgrade3();
                break;
        }
    }

    public void alteraUpgrades(int valor)
    {
        upgrades += valor;
    }

    public void Upgrade1()
    {
        turret1.SetActive(false);
        turret2.SetActive(true);
        turret3.SetActive(true);
    }

    public void Upgrade2()
    {
        turret1.SetActive(true);
        turret2.SetActive(true);
        turret3.SetActive(true);
    }

    public void Upgrade3()
    {
        turret1.SetActive(true);
        turret2.SetActive(true);
        turret3.SetActive(true);
        turret4.SetActive(true);
        turret5.SetActive(true);
    }
}
