using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UISalud : MonoBehaviour
{
    public Text textoSalud; // O TMP_Text si usás TextMeshPro

    public void ActualizarVida(int vida)
    {
        textoSalud.text = "Salud: " + vida.ToString();
    }
}