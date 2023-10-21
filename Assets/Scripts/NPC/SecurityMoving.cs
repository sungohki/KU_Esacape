using System.Collections;
using UnityEngine;
using UnityEngine.AI;
[System.Serializable] public class PatrolPoint
{
    [SerializeField] public float x;
    [SerializeField] public float z;

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
    Vector3 lastHeardSoundPosition; //sound 발생 위치 저장할 변수
    bool isInvestigatingSound = false; //sound 발생 위치 조사 중인지 여부
    bool isChasingPlayer = false;
    bool isAngry = false;
    [SerializeField] public Transform target;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        // 초기 목표 위치 설정
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
        // 다음 목표 위치를 배열에서 가져오고, 배열 인덱스를 업데이트
        PatrolPoint nextPatrolPoint = patrolPoints[currentPatrolPointIndex];
        currentPatrolPointIndex = (currentPatrolPointIndex + 1) % patrolPoints.Length;

        // PatrolPoint를 Vector3로 변환하여 NavMeshAgent에 다음 목표 위치 설정
        navMeshAgent.SetDestination(nextPatrolPoint.ToVector3());
    }

    //플레이어에서 soundPosition을 받아오는 함수
    public void HearSound(Vector3 soundPosition)
    {
        lastHeardSoundPosition = soundPosition;
        isInvestigatingSound = true;
    }

    // 2초간 경비원을 멈추고 조사를 끝내는 함수
    IEnumerator StopAndResumeInvestigation()
    {
        yield return new WaitForSeconds(2.0f);
        isInvestigatingSound = false;
    }

    void OnPlayerDetected()
    {
        // 플레이어를 감지하면 계속 추적
        Debug.Log("Player detected in SecuritySight!");
        isAngry = true;
        isChasingPlayer = true;
    }
}