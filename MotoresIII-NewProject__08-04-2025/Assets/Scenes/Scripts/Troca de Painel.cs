using UnityEngine;
public class TrocaDePainel : MonoBehaviour
{
    public GameObject painel1;
    public GameObject painel2;
    public void MostrarPainel1()
    {
    painel1.SetActive(true);
    painel2.SetActive(false);
    }
}