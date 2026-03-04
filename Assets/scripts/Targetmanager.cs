using UnityEngine;

public class Targetmanager : MonoBehaviour
{
    public GameObject Target;
    public Vector3 MinArea;
    public Vector3 MaxArea;
    private int TargetCount = 0;
    private int MaxTargetCount = 45;

    void Start()
    {
        InvokeRepeating("SpawnTarget", 0f, 1.5f);
    }

    void SpawnTarget()
    {
        if (TargetCount < MaxTargetCount)
        {
            float randomX = Random.Range(MinArea.x, MaxArea.x);
            float randomY = Random.Range(MinArea.y, MaxArea.y);
            float randomZ = Random.Range(MinArea.z, MaxArea.z);

            Vector3 randomSpawnPosition = new Vector3(randomX, randomY, randomZ);

            GameObject Newobject = Instantiate(Target, randomSpawnPosition, Quaternion.identity);

            TargetCount++;
        }
        else
        {
            CancelInvoke("SpawnTarget");
        }
    }
}
