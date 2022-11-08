using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraDeVida : MonoBehaviour
{
    public Image barradeVida;

    public float vidaActual;

    public float vidaMaxima;

    // Update is called once per frame
    void Update()
    {
        barradeVida.fillAmount = vidaActual / vidaMaxima;
    }
}
