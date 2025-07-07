using UnityEngine;

public class SaludManager : MonoBehaviour
{
    public int vidaActual = 100;
    public UISalud uiSalud;

    void Start()
    {
        if (uiSalud == null)
        {
            uiSalud = FindObjectOfType<UISalud>();
        }

        if (uiSalud != null)
        {
            uiSalud.ActualizarVida(vidaActual);
        }
    }

    public void RecibirDano(int cantidad)
    {
        vidaActual -= cantidad;

        if (vidaActual < 0)
            vidaActual = 0;

        if (uiSalud != null)
        {
            uiSalud.ActualizarVida(vidaActual);
        }

        if (vidaActual <= 0)
        {
            // Acá podés poner morir, reiniciar nivel, etc.
            Debug.Log("Jugador muerto.");
        }
    }
}

