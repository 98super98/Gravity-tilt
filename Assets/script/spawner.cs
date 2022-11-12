using UnityEngine;

public class spawner : MonoBehaviour
{
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        {
            rb.AddForce(transform.up,ForceMode2D.Force);
        }
    }
}