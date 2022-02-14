using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeBar : MonoBehaviour
{
    Image Bar;
    HealthSystem PlayerHealth;
    float health;
    float maxHealth;
    public float velocidadeDeQueda;
    float lerpSpeed;
    Color healthColor;
    public Color DamageColor;
    public Text numberText;
    void Start()
    {
        Bar = GetComponent<Image>();
        PlayerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<HealthSystem>();
        healthColor = Bar.color;
    }

    void Update()
    {
        if (PlayerHealth.health < 0) PlayerHealth.health = 0;
        lerpSpeed = velocidadeDeQueda * Time.unscaledDeltaTime;
        health = PlayerHealth.health;
        maxHealth = PlayerHealth.maxHealth;
        Bar.fillAmount = Mathf.Lerp(Bar.fillAmount, health / maxHealth, lerpSpeed);
        if (Bar.fillAmount <= 0.3)
        {
            Bar.color = DamageColor;
        }
        else
        {
            Bar.color = healthColor;
        }
        numberText.text = ((int)health).ToString() + " / " + ((int)maxHealth).ToString();
    }
}
