using System.Collections;
using UnityEngine;
using UnityEngine.AI;
[System.Serializable] public class PatrolPoint
{
    [SerializeField] public float x;
    [SerializeField] public float z;
    public AudioSource audioSource; // AudioSource ���� �߰�
    public AudioClip hmmSound; // hmm ���� Ŭ�� �߰�

    public PatrolPoint(float x, float z)
    {
        this.x = x;
        this.z = z;
    }

    public Vector3 ToVector3()
    {
        return new Vector3(x, 0, z);
    }
}

public class SecurityMoving : MonoBehaviour
{
    [SerializeField] public PatrolPoint[] patrolPoints;
    NavMeshAgent navMeshAgent;
    int currentPatrolPointIndex = 0;
    Vector3 lastHeardSoundPosition; //sound �߻� ��ġ ������ ����
    bool isInvestigatingSound = false; //sound �߻� ��ġ ���� ������ ����
    bool isChasingPlayer = false;
    bool isAngry = false;
    [SerializeField] public Transform target;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        // �ʱ� ��ǥ ��ġ ����
        SetNextPatrolPoint();
    }

    void Update()
    {
        if (!isInvestigatingSound && !isChasingPlayer)
        {
            if (navMeshAgent.remainingDistance < 0.1f)
            {
                SetNextPatrolPoint();
            }
        }
        else if (isInvestigatingSound)
        {
            navMeshAgent.SetDestination(lastHeardSoundPosition);
            StartCoroutine(StopAndResumeInvestigation());
        }
        else if (isChasingPlayer)
        {
            navMeshAgent.SetDestination(target.position);

            if (isAngry)
            {
                navMeshAgent.speed = 5 * navMeshAgent.speed;
            }
        }
    }

    void SetNextPatrolPoint()
    {
        // ���� ��ǥ ��ġ�� �迭���� ��������, �迭 �ε����� ������Ʈ
        PatrolPoint nextPatrolPoint = patrolPoints[currentPatrolPointIndex];
        currentPatrolPointIndex = (currentPatrolPointIndex + 1) % patrolPoints.Length;

        // PatrolPoint�� Vector3�� ��ȯ�Ͽ� NavMeshAgent�� ���� ��ǥ ��ġ ����
        navMeshAgent.SetDestination(nextPatrolPoint.ToVector3());
    }

    //�÷��̾�� soundPosition�� �޾ƿ��� �Լ�
    public void HearSound(Vector3 soundPosition)
    {
        lastHeardSoundPosition = soundPosition;
        isInvestigatingSound = true;
    }

    // 2�ʰ� ������ ���߰� ���縦 ������ �Լ�
    IEnumerator StopAndResumeInvestigation()
    {
        yield return new WaitForSeconds(2.0f);
        isInvestigatingSound = false;
    }

    void OnPlayerDetected()
    {
        // �÷��̾ �����ϸ� ��� ����
        Debug.Log("Player detected in SecuritySight!");
        isAngry = true;
        isChasingPlayer = true;
    }

}