using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using UnityEngine;

public class eNEMIGO : MonoBehaviour
{
    [SerializeField]
    private int valor;
    private ArrayList<Enemigo> enemigos;

    public Prueva()
    {
        enemigos = new ArrayList<Enemigo>();
    }

    public void CrearEnemigo()
    {
        enemigos.Add(e);
    }

    public void Atacar()
    {
        foreach (var item in collection)
        {

        }
    }

    public void Imprimir()
    {
        Debug.Log(valor);
    }

   
}
