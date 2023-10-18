using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoving : MonoBehaviour
{
    Vector3 dir; //�÷��̾� �̵� ������ ������ ����
    CharacterController cc; //���̺귯���� �ִ��� ���ѵ�

    [SerializeField] public float default_speed; //�ν����Ϳ��� ���������� ���� ���ǵ�.
    private float now_speed; // �÷��̾ �̵��ϴ� �̵��ӵ�.
    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>(); //ĳ���� ��Ʈ�ѷ��� ���� ������ ����
        now_speed = default_speed; //�̵��ӵ� �������ֱ�.
    }

    // Update is called once per frame
    void Update()
    {
        var h = Input.GetAxis("Horizontal"); //�Է°� ��������
        var v = Input.GetAxis("Vertical"); //�Է°� ��������

        if (Input.GetKey(KeyCode.LeftShift)) //�޽���Ʈ ��������
        {
            now_speed = default_speed * 1.5f; //�ι��~
        }

        else
        {
            now_speed = default_speed; //�ƴҶ� �׳�
        }


        dir = new Vector3(h, 0, v) * now_speed; //�̵����� ����

        transform.rotation = Quaternion.Euler(0, Mathf.Atan2(h, v) * Mathf.Rad2Deg, 0); //ȸ��ó��

        cc.Move(dir * Time.deltaTime); //�̵�ó��

    }
}
