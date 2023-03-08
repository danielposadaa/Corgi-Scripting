using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class MuroVisible : MonoBehaviour
{
    [SerializeField]
    private GameObject muro;
    private ControlLlaves control_llaves;
    public void Start()
    {
        control_llaves = this.transform.parent.GetComponent<ControlLlaves>();
       // control_llaves = this.GetComponent.ControlLlaves();
        //Debug.Log(control_llaves);
    }

    public void Update()
    {
       if(control_llaves.CantidadLlavesRecolectadas()==3);
        cambiarEstado(false);
    }
    public void cambiarEstado(bool estado)
    {
        muro.SetActive(estado);
    }
}
