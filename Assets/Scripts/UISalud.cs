using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UISalud : MonoBehaviour
{
    public TextMeshProUGUI textoSalud; // O TMP_Text si usás TextMeshPro

    private void Start()
    {
        Debug.Log(gameObject.name);
    }

    public void ActualizarVida(int vida)
    {
        textoSalud.text = "Salud: " + vida.ToString();
    }
}