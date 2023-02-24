using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.CorgiEngine;
using MoreMountains.Tools;
using UnityEngine.SceneManagement;

public class controlmenu : MonoBehaviour
{
    public void OnpressJugar()
    {
        MMSceneLoadingManager.LoadScene("Juego");
        SceneManager.LoadScene("Juego", LoadSceneMode.Single);
    }

    public void Onpressinstrucciones()
    {
        MMSceneLoadingManager.LoadScene("Instrucciones");
        SceneManager.LoadScene("instrucciones", LoadSceneMode.Single);
    }

    public void OnpressVolverMenu()
    {
        MMSceneLoadingManager.LoadScene("Menu");
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }

    public void OnpressSalir()
    {
        MMSceneLoadingManager.LoadScene("Salir");
    }
}