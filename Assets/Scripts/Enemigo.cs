using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public int dano = 20;
    private SaludManager saludManager;

    void Start()
    {
        saludManager = FindObjectOfType<SaludManager>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (saludManager != null)
            {
                saludManager.RecibirDano(dano);
            }

            Destroy(gameObject); // Esto es opcional, podés sacarlo si no querés que desaparezca
        }
    }
}
