using UnityEngine;

public class Velocidade1 : MonoBehaviour
{
    public float velocidade = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Rigidbody2D _rigidbody2D;
    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.position += new Vector3(-velocidade * Time.deltaTime, 0, 0);
            //rigidbody2D.AddForce(new Vector2(-velocidade,0));
            spriteRenderer.flipX = false;
            Debug.Log("LeftArrow");
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.position += new Vector3(velocidade * Time.deltaTime, 0, 0);
            //rigidbody2D.AddForce(new Vector2(velocidade,0));
            spriteRenderer.flipX = true;
            Debug.Log("RightArrow");
        }

        float movimentoVertical = 0f;
        if (Input.GetKey(KeyCode.UpArrow)) { movimentoVertical = 1f; }
        else if (Input.GetKey(KeyCode.DownArrow)) { movimentoVertical = -1f; }
        else { movimentoVertical = 0f; }
        transform.position += new Vector3(0f, movimentoVertical, 0f) * velocidade * Time.deltaTime;
    }
}