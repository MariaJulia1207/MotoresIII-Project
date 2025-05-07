using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float rotationSpeed = 100f; // Velocidade de rotação em graus porsegundo

    void Update()
    {
        // Rotaciona o objeto ao redor do eixo Z continuamente
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }
}
