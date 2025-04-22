using UnityEngine;

public class TorqueExample : MonoBehaviour
{
    private Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        float torque = 10f; // Torque em graus
        rb.AddTorque(torque, ForceMode2D.Impulse); // Aplica o torque
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
