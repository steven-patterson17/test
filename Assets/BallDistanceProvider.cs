using UnityEngine;

public class BallDistanceProvider : MonoBehaviour
{
    private Vector3 startPos;
    public float Distance { get; private set; }

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        Distance = Vector3.Distance(startPos, transform.position);
    }
}
