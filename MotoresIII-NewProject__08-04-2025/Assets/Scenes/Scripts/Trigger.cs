using UnityEngine;

public class Trigger : MonoBehaviour
{
    public float velocidade = 5f;
    private Vector2 direcao = Vector2.right;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        // Move o objeto constantemente na direção atual
        transform.Translate(direcao * velocidade * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Entrou em trigger com: " + other.gameObject.name);
        GetComponent<SpriteRenderer>().color = Color.red;
    }
    void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("Saiu do trigger com: " + other.gameObject.name);
        GetComponent<SpriteRenderer>().color = Color.white;
    }
    
}
