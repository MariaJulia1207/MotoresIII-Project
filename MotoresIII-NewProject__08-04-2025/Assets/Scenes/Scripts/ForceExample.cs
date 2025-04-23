using UnityEngine;

public class ForceExample : MonoBehaviour
{

    private Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Vector2 force = new Vector2(10f, 0f); // For�a para a direita
        rb.AddForce(force, ForceMode2D.Impulse); // Aplica a for�a instantaneamente
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
