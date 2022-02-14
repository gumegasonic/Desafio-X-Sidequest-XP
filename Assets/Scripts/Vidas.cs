using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vidas : MonoBehaviour
{
    public int vidas;
    public Text contadordeVidas;
    public TMPro.TextMeshProUGUI botaoContinue;
    public Color noLifeColor;
    private Color corPadrao;
    void Start()
    {
        corPadrao = botaoContinue.color;
    }

    void Update()
    {
        contadordeVidas.text = "Vidas: " + vidas.ToString();
        if(vidas <= 0)
        {
            botaoContinue.color = noLifeColor;
        }
        else
        {
            botaoContinue.color = corPadrao;
        }
    }

    public void AlteraVida(int valor)
    {
        vidas += valor;
    }
}
