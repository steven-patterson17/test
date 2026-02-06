using UnityEngine;

public class WallGenerator : MonoBehaviour
{
    [SerializeField]
    GameObject brickPrefab;

    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            for(int j = 0; j < 5; j++)
            {
                Vector3 pos = new Vector3(i * 2, j, 0);
                Instantiate(brickPrefab, pos, Quaternion.identity);
            }
        }
    }
}