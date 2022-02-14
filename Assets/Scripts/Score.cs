using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int score = 0;
    public Text scoreBoard;
    void Start()
    {
        
    }

    void Update()
    {
        scoreBoard.text = "Pontuação: " + score.ToString();
    }

    public void AlteraScore(int valor)
    {
        score += valor;
    }
}
