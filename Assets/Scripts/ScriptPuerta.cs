using UnityEngine;

public class ScriptPuerta : MonoBehaviour
{
    public Animator animador;
    public Collider2D colliderBloqueo;
    private bool jugadorCerca = false;
    private bool yaSeAbrio = false;

    void Update()
    {
        if (jugadorCerca && !yaSeAbrio && Input.GetKeyDown(KeyCode.E))
        {
            yaSeAbrio = true; 
            animador.SetTrigger("Abrir");

            Invoke(nameof(DesbloquearPuerta), 0.5f);
        }
    }

    void DesbloquearPuerta()
    {
        if (colliderBloqueo != null)
            colliderBloqueo.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            jugadorCerca = true;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            jugadorCerca = false;
    }
}
