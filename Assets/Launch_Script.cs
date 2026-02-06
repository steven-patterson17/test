using TMPro;
using UnityEngine;

public class PingPongLauncher : MonoBehaviour
{
    [Header("Ball Settings")]
    public GameObject Ping_Pong_Ball;
    public Transform LaunchPoint;
    public float launchForce = 12f;

    [Header("Auto Aim & Fire")]
    public Transform player;
    public float fireRate = 2f;

    private float timer;

    [Header("UI")]
    public BallSpeedUI speedUI;
    public TextMeshProUGUI distanceText;

    void Update()
    {
        // Aim at the player
        if (player != null)
        {
            LaunchPoint.forward = (player.position - LaunchPoint.position).normalized;
        }

        // Fire on a timer
        timer += Time.deltaTime;
        if (timer >= fireRate)
        {
            Shoot();
            timer = 0f;
        }
    }

    public void Shoot()
    {
        GameObject ball = Instantiate(Ping_Pong_Ball, LaunchPoint.position, LaunchPoint.rotation);
        Rigidbody rb = ball.GetComponent<Rigidbody>();

        // Add random spread
        Vector3 spread = LaunchPoint.forward
            + new Vector3(
                Random.Range(-0.05f, 0.05f),
                Random.Range(-0.05f, 0.05f),
                0f);

        // Correct velocity assignment
        rb.linearVelocity = spread.normalized * launchForce;

        // Assign distance UI
        BallDistanceTracker tracker = ball.GetComponent<BallDistanceTracker>();
        tracker.distanceText = distanceText;

        // Assign speed UI
        speedUI.SetBall(rb);

        // Destroy after 5 seconds
        Destroy(ball, 5f);
    }
}
