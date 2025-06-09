using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UISalud : MonoBehaviour
{
    public TextMeshProUGUI Txt_Salud;

    public void UpdateMoneyText(string money)
    {
        Txt_Salud.text = "salud" + money;
    }
}
