using UnityEngine;

public class PincheTrampa : MonoBehaviour
{
    public int dano = 10;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Buscar el componente de salud
            SaludManager salud = other.GetComponent<SaludManager>();
            if (salud == null)
            {
                salud = FindObjectOfType<SaludManager>();
            }

            if (salud != null)
            {
                salud.RecibirDano(dano);
                Debug.Log("Trampa activada: se bajó vida");
            }

            // Destruir la trampa
            Destroy(gameObject);
        }
    }
}