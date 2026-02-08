using UnityEngine;

public class PingPongLauncher : MonoBehaviour
{
    [Header("Ball Settings")]
    public GameObject Ping_Pong_Ball;
    public Transform LaunchPoint;
    public float launchForce = 12f;

    [Header("Auto Aim & Fire")]
    public Transform player;
    public float fireRate = 5f;

    private float timer;

    [Header("UI")]
    public MetricsBoardUI metricsBoard;

    void Update()
    {
        if (player != null)
        {
            LaunchPoint.forward = (player.position - LaunchPoint.position).normalized;
        }

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

        Vector3 spread = LaunchPoint.forward
            + new Vector3(
                Random.Range(-0.05f, 0.05f),
                Random.Range(-0.05f, 0.05f),
                0f);

        rb.linearVelocity = spread.normalized * launchForce;
        rb.AddTorque(Random.insideUnitSphere * 0.1f, ForceMode.Impulse);

        // Assign providers to the board
        metricsBoard.speedProvider = ball.GetComponent<BallSpeedProvider>();
        metricsBoard.distanceProvider = ball.GetComponent<BallDistanceProvider>();

        Destroy(ball, 5f);
    }
}
