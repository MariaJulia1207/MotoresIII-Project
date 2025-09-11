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
    public void MostrarPainel2()
    {
        painel1.SetActive(false);
        painel2.SetActive(true);
    }
}
