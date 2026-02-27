using UnityEngine;

public class Targetmanager : MonoBehaviour
{
    public GameObject Target;
    public Vector3 MinArea;
    public Vector3 MaxArea;
    private int TargetCount = 0;
    private int MaxTargetCount = 20;

    void Start()
    {
        InvokeRepeating("SpawnTarget", 0f, 2f);
    }

    void SpawnTarget()
    {
        if (TargetCount < MaxTargetCount)
        {
            float randomX = Random.Range(MinArea.x, MaxArea.x);
            float randomY = Random.Range(MinArea.y, MaxArea.y);

            Vector3 randomSpawnPosition = new Vector3(randomX, randomY, 0);

            GameObject Newobject = Instantiate(Target, randomSpawnPosition, Quaternion.identity);

            TargetCount++;
        }
        else
        {
            CancelInvoke("SpawnTarget");
        }
    }
}
