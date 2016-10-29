using UnityEngine;

public class Pumpkin : MonoBehaviour
{
    void Start()
    {
        var rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(Random.Range(-300, 300), 500));
        rb.AddTorque(2);
    }
}