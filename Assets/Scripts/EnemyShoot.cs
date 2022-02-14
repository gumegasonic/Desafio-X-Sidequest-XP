using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    float tempoAtual;
    public float fireRate;
    public GameObject prefab;
    public Transform spawn;
    public Vector2 forca;
    public AudioSource audioSource;
    public AudioClip shootSound;
    [Range(0, 1)]
    public float volume;
    public SoundManager SFX;
    private GameObject bloqueador;
    void Start()
    {
        SFX = FindObjectOfType<SoundManager>();
        bloqueador = GameObject.Find("Bloqueador");
    }

    void Update()
    {
        atirar();
    }

    void atirar()
    {
        if (tempoAtual < Time.time)
        {
            if(this.transform.position.y < bloqueador.transform.position.y && this.transform.position.y > bloqueador.transform.position.y - 12)
            {
                SFX.Play("Inimigo");
            }
            tempoAtual = Time.time + fireRate;
            GameObject projetil = Instantiate(prefab, spawn.position, spawn.rotation);
            projetil.GetComponent<Projectile>().spawner = this.gameObject;
            projetil.GetComponent<Rigidbody2D>().AddForce(forca);
        }
    }
}