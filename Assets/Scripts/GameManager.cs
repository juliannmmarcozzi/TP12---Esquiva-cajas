using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static bool gameOver = false;

    public TMP_Text tiempoTexto;

    float tiempo = 0f;

    void Update()
    {
        if(gameOver == false)
        {
            tiempo += Time.deltaTime;

            tiempoTexto.text = "Tiempo: " + tiempo.ToString("F2");
        }
    }
}