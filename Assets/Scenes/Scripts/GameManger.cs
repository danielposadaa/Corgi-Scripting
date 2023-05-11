using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{
    public GameObject ventanaInformativa;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            ventanaInformativa.SetActive(true);
        }
    }
}
