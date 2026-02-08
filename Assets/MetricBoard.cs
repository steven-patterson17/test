using UnityEngine;
using TMPro;

public class MetricsBoardUI : MonoBehaviour
{
    public BallSpeedProvider speedProvider;
    public BallDistanceProvider distanceProvider;

    public TextMeshProUGUI speedText;
    public TextMeshProUGUI distanceText;

    void Update()
    {
        if (speedProvider != null)
            speedText.text = "Speed: " + speedProvider.Speed.ToString("F2") + " f/s";

        if (distanceProvider != null)
            distanceText.text = "Distance: " + distanceProvider.Distance.ToString("F2") + " m";
    }

}
