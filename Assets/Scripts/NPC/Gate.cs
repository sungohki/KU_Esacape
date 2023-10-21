using UnityEngine;

public class Gate : MonoBehaviour
{
    [SerializeField] private GameObject door; // 문 오브젝트

    private Vector3 closedPosition; // 문이 닫혀있는 위치
    private Vector3 openPosition; // 문이 열린 위치
    private float doorSpeed = 1.0f; // 문 열리는 속도

    private bool isOpen = false; // 문 열림 상태

    private void Start()
    {
        // 초기 위치 설정
        closedPosition = door.transform.position;
        openPosition = new Vector3(closedPosition.x - 1.0f, closedPosition.y, closedPosition.z);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // 예를 들어, 스페이스바를 눌렀을 때
        {
            if (isOpen)
            {
                CloseDoor();
            }
            else
            {
                OpenDoor();
            }
        }
    }

    private void OpenDoor()
    {
        isOpen = true;
    }

    private void CloseDoor()
    {
        isOpen = false;
    }

    private void FixedUpdate()
    {
        // 문을 열 때
        if (isOpen && Vector3.Distance(door.transform.position, openPosition) > 0.01f)
        {
            // 문을 스르륵 열기
            door.transform.position = Vector3.MoveTowards(door.transform.position, openPosition, doorSpeed * Time.deltaTime);
        }
        // 문을 닫을 때
        else if (!isOpen && Vector3.Distance(door.transform.position, closedPosition) > 0.01f)
        {
            // 문을 스르륵 닫기
            door.transform.position = Vector3.MoveTowards(door.transform.position, closedPosition, doorSpeed * Time.deltaTime);
        }
    }
}