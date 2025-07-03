using TMPro;
using UnityEngine;
public class HUDController : MonoBehaviour
{
    public TextMeshProUGUI relogioTexto;
    private float tempo;
    void Update()
    {
        // Atualiza tempo
        tempo += Time.deltaTime;
        relogioTexto.text = "Tempo: " + tempo.ToString("F1"); // ex: Tempo: 10.3
    }
}