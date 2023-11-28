using UnityEngine;

public class CatAnimationController : MonoBehaviour
{
    private Animator catAnimator;
    private Vector3 lastPosition;
    private bool isMoving;

    void Start()
    {
        catAnimator = GetComponent<Animator>();
        lastPosition = transform.position;
    }

    void Update()
    {
        // ���� ��ġ�� ���� ��ġ�� ���Ͽ� �������� ����
        if (transform.position != lastPosition)
        {
            isMoving = true;
        }
        else
        {
            isMoving = false;
        }

        // �̵� ���ο� ���� �ִϸ��̼� ���
        if (isMoving)
        {
            catAnimator.SetBool("IsMoving", true); // walk �ִϸ��̼� ���
        }
        else
        {
            catAnimator.SetBool("IsMoving", false); // idle �ִϸ��̼� ���
        }

        lastPosition = transform.position;
    }
}
