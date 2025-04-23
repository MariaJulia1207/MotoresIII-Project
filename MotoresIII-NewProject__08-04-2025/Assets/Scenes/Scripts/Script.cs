using UnityEngine;

public class Script : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Rigidbody2D meuRigidbody;
    BoxCollider2D meuBC;
    void Start()
    {
        meuRigidbody = GetComponent<Rigidbody2D>();
        meuRigidbody.gravityScale = 10f;
        meuBC = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
