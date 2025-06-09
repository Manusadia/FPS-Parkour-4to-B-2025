using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaludManager : MonoBehaviour
{
    public int salud;
    public UIManager uiManager;

    void Start()
    {
        uiManager = FindObjectOfType<UIManager>();
    }

    public bool UpdateSalud(int vida)
    {
        if (salud <= vida)
        {
            Debug.Log("No tenes mas vida, Moriste");
            return false;
        }
        salud -= vida;
        uiManager.UpdateSaludText(vida.ToString());
        return true;
           
    }
}
