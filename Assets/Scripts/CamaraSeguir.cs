using UnityEngine;

public class CamaraSeguir : MonoBehaviour
{
    public Transform objetivo;
    public Vector3 offset = new Vector3(0f, 0f, -10f);
    public int pixelsPerUnit = 32;

    void LateUpdate()
    {
        if (objetivo != null)
        {
            float unitsPerPixel = 1f / pixelsPerUnit;

            Vector3 posicionObjetivo = objetivo.position;
            posicionObjetivo.x = Mathf.Round(posicionObjetivo.x / unitsPerPixel) * unitsPerPixel;
            posicionObjetivo.y = Mathf.Round(posicionObjetivo.y / unitsPerPixel) * unitsPerPixel;

            Vector3 destino = posicionObjetivo + offset;
            destino.x = Mathf.Round(destino.x / unitsPerPixel) * unitsPerPixel;
            destino.y = Mathf.Round(destino.y / unitsPerPixel) * unitsPerPixel;
            destino.z = offset.z;

            transform.position = destino;
        }
    }
}
