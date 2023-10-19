using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

//������ũ, Ŭ������ �빮�ڽ��� ��������
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
                // ���� �ӵ��� �̵� ������ ���⿡ �ۼ�
                // ���� ���, NavMesh �Ǵ� Rigidbody�� ����Ͽ� �̵�

                // �ֱ������� �̵� ������ ����
                yield return new WaitForSeconds(turn_interval);
                ChangeDirection();
            }
            yield return null;
        }
    }

    IEnumerator MoveFast()
    {
        moving_fast = true;
        // ���� �ӵ��� �̵� ������ ���⿡ �ۼ�

        yield return new WaitForSeconds(10.0f);

        moving_fast = false;
        StartCoroutine(MoveSlowly()); // �ٽ� ���� �ӵ��� �̵�
    }

    void ChangeDirection()
    {
        float randomAngle = Random.Range(0.0f, 360.0f);
        transform.rotation = Quaternion.Euler(0.0f, randomAngle, 0.0f);
    }
}

