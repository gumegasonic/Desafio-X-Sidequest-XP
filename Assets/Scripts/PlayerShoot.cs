using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    float tempoAtual;
    public float fireRate;
    public GameObject prefab;
    public Transform spawn;
    public Vector2 forca;
    public bool isNotTurret1;
    public GameObject turret1;
    private SoundManager SFX;
    void Start()
    {
        SFX = FindObjectOfType<SoundManager>();
    }

    void Update()
    {
        if (Time.timeScale > 0)
        {
            atirar();
        }
    }

    void atirar()
    {
        if (tempoAtual < Time.time && Input.GetMouseButton(0))
        {
            if (isNotTurret1)
            {
                if (turret1.activeSelf == false && !this.gameObject.CompareTag("TurretDireita"))
                {
                    SFX.PlayOneShot("PlayerShoot");
                }
            }
            else
            {
                SFX.PlayOneShot("PlayerShoot");
            }
            tempoAtual = Time.time + fireRate;
            GameObject projetil = Instantiate(prefab, spawn.position, spawn.rotation);
            projetil.GetComponent<Projectile>().spawner = this.gameObject;
            projetil.GetComponent<Rigidbody2D>().AddForce(forca);
        }
    }
}
