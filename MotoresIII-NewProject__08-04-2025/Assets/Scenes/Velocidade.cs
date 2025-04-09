using UnityEngine;

public class Velocidade : MonoBehaviour
{
    public float velocidade = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float movimentoHorizontal = 0f;
        if (Input.GetKey(KeyCode.RightArrow)) { movimentoHorizontal = 1f; }
        else if (Input.GetKey(KeyCode.LeftArrow)) { movimentoHorizontal = -1f; }
        else { movimentoHorizontal = 0f; }
        transform.position += new Vector3(movimentoHorizontal, 0f, 0f) * velocidade * Time.deltaTime;

        float movimentoVertical = 0f;
        if (Input.GetKey(KeyCode.UpArrow)) { movimentoVertical = 1f; }
        else if (Input.GetKey(KeyCode.DownArrow)) { movimentoVertical = -1f; }
        else { movimentoVertical = 0f; }
        transform.position += new Vector3(0f, movimentoVertical, 0f) * velocidade * Time.deltaTime;
    }
}
