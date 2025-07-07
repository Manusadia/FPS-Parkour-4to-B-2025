using UnityEngine;

public class PincheTrampa : MonoBehaviour
{
    public int dano = 10;

    void OnTriggerEnter(Collider other)

    {

     
        if (other.gameObject.CompareTag("Player"))
        {
            // Buscar el componente de salud
            SaludManager salud = other.gameObject.GetComponent<SaludManager>();
            if (salud == null)
            {
                salud = FindObjectOfType<SaludManager>();
            }

            if (salud != null)
            {
                salud.RecibirDano(dano);
                Debug.Log("se bajó vida");
            }

            // Destruir la trampa
            Destroy(gameObject);
        }
    }
}