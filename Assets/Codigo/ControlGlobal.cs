using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlGlobal : MonoBehaviour
{
    public static string menuToActivate = ""; // Nombre del menú a activar en la próxima escena

    public void cambiarEscena(string escena)
    {
        SceneManager.LoadScene(escena);
    }
}
