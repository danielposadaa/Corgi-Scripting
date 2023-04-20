using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;

public class ControlMuerte : MonoBehaviour, MMEventListener<CorgiEngineEvent>, MMEventListener<PickableItemEvent>
{
    [SerializeField]
    private List<GameObject> Corazones;

    private int vidas;

    private int Contador_Monedas;

    [SerializeField]

    private int Total_Monedas;

    public void Start()
    {
        vidas = Corazones.Count;
    }

    public virtual void OnMMEvent (CorgiEngineEvent e)
    {
        if (e.EventType == CorgiEngineEventTypes.PlayerDeath)
        {
            if (vidas-1 >=0)
            {
                vidas--;
                Contador_Monedas = 0;
                Corazones[vidas].SetActive(false);
            }
        }
    }

    public virtual void OnMMEvent(PickableItemEvent e)
    {
        Debug.Log("Pick");
        Contador_Monedas++;
        Debug.Log("Contador Monedas" + Contador_Monedas + "vidas" + vidas);
        if(Contador_Monedas == Total_Monedas && vidas+1 <= Corazones.Count)
        {
            Corazones[vidas].SetActive(true);
            vidas++;
            Contador_Monedas = 0;
        }
    }

    void OnEnable()
    {
        this.MMEventStartListening<CorgiEngineEvent>();
        this.MMEventStartListening<PickableItemEvent>();
    }

    void OnDisable()
    {
        this.MMEventStopListening<CorgiEngineEvent>();
        this.MMEventStopListening<PickableItemEvent>();
    }
    
}
