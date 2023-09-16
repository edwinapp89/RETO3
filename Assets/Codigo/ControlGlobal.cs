using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlGlobal : MonoBehaviour
{
    public static string menuToActivate = ""; // Nombre del men� a activar en la pr�xima escena

    public void cambiarEscena(string escena)
    {
        SceneManager.LoadScene(escena);
    }
}
