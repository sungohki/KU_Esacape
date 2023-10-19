using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

//스네이크, 클래스는 대문자시작 잊지말기
public class CatMoving : MonoBehaviour
{
    [SerializeField] public float roam_speed;
    [SerializeField] public float rush_speed;
    [SerializeField] public float turn_interval;
    [SerializeField] public float roam_range;
    private bool moving_fast = false;
    NavMeshAgent navMeshAgent;
    [SerializeField] Transform target;

    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        StartCoroutine(MoveSlowly());
    }

    // Update is called once per frame
    void Update()
    {
        navMeshAgent.SetDestination(target.position);
    }

    IEnumerator MoveSlowly()
    {
        while (true)
        {
            if (!moving_fast)
            {
                // 느린 속도로 이동 로직을 여기에 작성
                // 예를 들어, NavMesh 또는 Rigidbody를 사용하여 이동

                // 주기적으로 이동 방향을 변경
                yield return new WaitForSeconds(turn_interval);
                ChangeDirection();
            }
            yield return null;
        }
    }

    IEnumerator MoveFast()
    {
        moving_fast = true;
        // 빠른 속도로 이동 로직을 여기에 작성

        yield return new WaitForSeconds(10.0f);

        moving_fast = false;
        StartCoroutine(MoveSlowly()); // 다시 느린 속도로 이동
    }

    void ChangeDirection()
    {
        float randomAngle = Random.Range(0.0f, 360.0f);
        transform.rotation = Quaternion.Euler(0.0f, randomAngle, 0.0f);
    }
}

