using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI txtMoney;
    public TextMeshProUGUI txtSalud;

    public void UpdateMoneyText(string money)
    {
        txtMoney.text = "$" + money;
    }
    public void UpdateSaludText(string salud)
    {
        txtSalud.text = salud;
    }
}
