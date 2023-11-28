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
        // 현재 위치와 이전 위치를 비교하여 움직임을 감지
        if (transform.position != lastPosition)
        {
            isMoving = true;
        }
        else
        {
            isMoving = false;
        }

        // 이동 여부에 따라 애니메이션 재생
        if (isMoving)
        {
            catAnimator.SetBool("IsMoving", true); // walk 애니메이션 재생
        }
        else
        {
            catAnimator.SetBool("IsMoving", false); // idle 애니메이션 재생
        }

        lastPosition = transform.position;
    }
}
