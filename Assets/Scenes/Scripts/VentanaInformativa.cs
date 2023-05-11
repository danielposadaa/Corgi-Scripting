using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class VentanaInformativa : MonoBehaviour
{
    public TMP_Text textoVentana;
    public float tiempoPista = 5f;
    public string[] pistas;
    private int indicePista = 0;

    void Start()
    {
        StartCoroutine(MostrarPistas());
    }

    IEnumerator MostrarPistas()
    {
        while (true)
        {
            textoVentana.text = pistas[indicePista];
            yield return new WaitForSeconds(tiempoPista);
            indicePista = (indicePista + 1) % pistas.Length;
        }
    }
}

