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
    public GameObject catPrefab;  // Cat ���� ������
    public SpawnPoint[] spawnPoints;  // ���Ͱ� ������ ��ġ
    public float spawnInterval = 30.0f;  // ���� �ֱ� (30��)

    void Start()
    {
        // �����ϸ� �ֱ������� ���� ���� �ڷ�ƾ ����
        StartCoroutine(SpawnNpcs());
    }

    IEnumerator SpawnNpcs()
    {
        while (true)
        {
            // �����ϰ� Spawn Point �� �ϳ��� ����
            SpawnPoint randomSpawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];

            // Cat ���� ����
            CreateNpc(catPrefab, randomSpawnPoint.ToVector3());

            yield return new WaitForSeconds(spawnInterval);
        }
    }

    void CreateNpc(GameObject npcPrefab, Vector3 position)
    {
        // �־��� ��ġ�� ���� ����
        Instantiate(npcPrefab, position, Quaternion.identity);
    }
}
