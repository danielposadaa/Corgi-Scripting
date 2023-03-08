using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Diagnostics;

public class ControlLlaves : MonoBehaviour
{
    [SerializeField]
    private TMP_Text txt_contador_llaves;
    private int contador_llaves;
   
    public void Start()
    {

    }
    public int CantidadLlavesRecolectadas()
    {
        return contador_llaves;
    }


    public void ActualizarPuntaje(int valor)
    {
        contador_llaves += valor;
        ActualizarValor();
    }

    public void ActualizarValor()
    {
        txt_contador_llaves.text = ""+contador_llaves;
    }
}
