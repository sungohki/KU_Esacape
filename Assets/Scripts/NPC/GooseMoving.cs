using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GooseMoving : MonoBehaviour
{
    NavMeshAgent navMeshAgent; //�׺���̼� ���
    [SerializeField] public Transform target; //�Ѿƾ��� ���
    Vector3 initial_position; //���� ���� ��ġ
    bool isReturning = false;

    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>(); //��ã��
        initial_position = transform.position;//���� �ʱ� ��ġ ����
    }

    // Update is called once per frame
    void Update()
    {
        if (isReturning)
        {
            navMeshAgent.SetDestination(initial_position);
        }

        else
        {
            navMeshAgent.SetDestination(target.position);

        }
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Sight"))
        {
            Debug.Log("Touch!");
            StartCoroutine(Run5Second());
        }
    }

    IEnumerator Run5Second()
    {
        isReturning = true; // �ʱ� ��ġ�� �̵��ϵ��� �÷��� ����

        float normal_speed = navMeshAgent.speed;
        navMeshAgent.speed = normal_speed * 3.0f;
        navMeshAgent.SetDestination(initial_position);

        yield return new WaitForSeconds(5.0f);

        isReturning = false; // �ٽ� �÷��̾ �����ϵ��� �÷��� ����
        navMeshAgent.speed = normal_speed;
    }
}
