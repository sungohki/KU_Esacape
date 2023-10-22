using System.Collections;
using UnityEngine;

[System.Serializable]
public class SpawnPoint
{
    [SerializeField] public float x;
    [SerializeField] public float z;

    public SpawnPoint(float x, float z)
    {
        this.x = x;
        this.z = z;
    }

    public Vector3 ToVector3()
    {
        return new Vector3(x, 0, z);
    }
}

public class NpcManager : MonoBehaviour
{
    public GameObject catPrefab;  // Cat 몬스터 프리팹
    public SpawnPoint[] spawnPoints;  // 몬스터가 생성될 위치
    public float spawnInterval = 30.0f;  // 생성 주기 (30초)

    void Start()
    {
        // 시작하면 주기적으로 몬스터 생성 코루틴 시작
        StartCoroutine(SpawnNpcs());
    }

    IEnumerator SpawnNpcs()
    {
        while (true)
        {
            // 랜덤하게 Spawn Point 중 하나를 선택
            SpawnPoint randomSpawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];

            // Cat 몬스터 생성
            CreateNpc(catPrefab, randomSpawnPoint.ToVector3());

            yield return new WaitForSeconds(spawnInterval);
        }
    }

    void CreateNpc(GameObject npcPrefab, Vector3 position)
    {
        // 주어진 위치에 몬스터 생성
        Instantiate(npcPrefab, position, Quaternion.identity);
    }
}
