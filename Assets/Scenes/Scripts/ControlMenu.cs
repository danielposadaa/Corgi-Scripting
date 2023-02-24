using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlMenu : MonoBehaviour
{
    public void OnpressJugar()
    {
        //MMSceneLoadingManager.LoadScene("Jugar");
        SceneManager.LoadScene("Juego", LoadSceneMode.Single);
    }
    public void OnPressPausa()
    {
        Debug.Log("Pausa");
       // MMSceneLoadingManager.LoadScene("Pausa");
        SceneManager.LoadScene("Pausa", LoadSceneMode.Single);
    }
    public void OnpressExit()
    {
        //MMSceneLoadingManager.LoadScene("Jugar");
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }
    public void OnPressPause()
    {
        Debug.Log("Pausa");
        // MMSceneLoadingManager.LoadScene("Pausa");
        SceneManager.LoadScene("Pausa", LoadSceneMode.Single);
    }
}
