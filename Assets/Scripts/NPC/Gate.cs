using UnityEngine;

public class Gate : MonoBehaviour
{
    [SerializeField] private GameObject door; // �� ������Ʈ

    private Vector3 closedPosition; // ���� �����ִ� ��ġ
    private Vector3 openPosition; // ���� ���� ��ġ
    private float doorSpeed = 1.0f; // �� ������ �ӵ�

    private bool isOpen = false; // �� ���� ����

    private void Start()
    {
        // �ʱ� ��ġ ����
        closedPosition = door.transform.position;
        openPosition = new Vector3(closedPosition.x - 1.0f, closedPosition.y, closedPosition.z);
    }

    private void Update()
    {
        // openDoor();
    }

    public void openDoor() {
        if (Input.GetKey(KeyCode.Space)) {
            // Debug.Log("Door Open");
            isOpen = true;
        }
        else {
            Debug.Log("Door Close");
            isOpen = false;
        }
    }
    private void FixedUpdate()
    {
        // ���� �� ��
        if (isOpen && Vector3.Distance(door.transform.position, openPosition) > 0.01f)
        {
            // ���� ������ ����
            door.transform.position = Vector3.MoveTowards(door.transform.position, openPosition, doorSpeed * Time.deltaTime);
        }
        // ���� ���� ��
        else if (!isOpen && Vector3.Distance(door.transform.position, closedPosition) > 0.01f)
        {
            // ���� ������ �ݱ�
            door.transform.position = Vector3.MoveTowards(door.transform.position, closedPosition, doorSpeed * Time.deltaTime);
        }
    }
}