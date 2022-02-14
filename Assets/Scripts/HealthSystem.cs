using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public bool regeneracao;
    public float timerRegeneracao;
    private float timerRegeneracaoAtual;
    public float velocidadeDeRegeneracao;
    public float maxHealth;
    [HideInInspector]
    public float health;
    public GameObject explosion;
    public int pontuacao;
    private Score scoreBoard;
    public bool dropPowerUP;
    public GameObject powerUP;
    private Transform tr;
    void Start()
    {
        tr = this.transform;
        health = maxHealth;
        timerRegeneracaoAtual += Time.time;
        scoreBoard = GameObject.FindGameObjectWithTag("ScoreBoard").GetComponent<Score>();
    }

    void FixedUpdate()
    {
        if (health > maxHealth) health = maxHealth;

        if (health <= 0)
        {
            GameObject explosao = Instantiate(explosion, this.transform.position, this.transform.rotation);
            if (!this.gameObject.CompareTag("Player"))
            {
                if (dropPowerUP)
                {
                    GameObject drop = Instantiate(powerUP, tr.position, powerUP.transform.rotation);
                }
                FindObjectOfType<SoundManager>().Play("Explosao");
                scoreBoard.AlteraScore(pontuacao);
                Destroy(this.gameObject);
            }
            else
            {
                FindObjectOfType<SoundManager>().Play("Explosao");
                this.GetComponent<Vidas>().AlteraVida(-1);
                this.gameObject.SetActive(false);
            }
        }

        if (regeneracao)
        {
            if (Time.time > timerRegeneracaoAtual && health < maxHealth)
            {
                health += velocidadeDeRegeneracao * Time.fixedDeltaTime;
            }
        }
    }

    public void modifyHealth(int valor)
    {
        health += valor;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Projectile") || collision.CompareTag("Laser"))
        {
            timerRegeneracaoAtual = timerRegeneracao + Time.time;
        }
    }
}
