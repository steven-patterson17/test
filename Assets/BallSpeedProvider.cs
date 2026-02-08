using UnityEngine;

public class BallSpeedProvider : MonoBehaviour
{
    private Rigidbody rb;
    public float Speed { get; private set; }

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Speed = rb.linearVelocity.magnitude;
    }
}
