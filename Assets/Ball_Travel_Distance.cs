using UnityEngine;
using TMPro;

public class BallDistanceTracker : MonoBehaviour
{
    public TextMeshProUGUI distanceText;
    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        float distance = Vector3.Distance(startPos, transform.position);
        distanceText.text = "Distance: " + distance.ToString("F2") + " m";
    }
}
