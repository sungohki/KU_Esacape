using System.Collections;
using UnityEngine;

public class TutoSecurity : MonoBehaviour
{

    Vector3 lastHeardSoundPosition; //sound �߻� ��ġ ������ ����
    bool isInvestigatingSound = false; //sound �߻� ��ġ ���� ������ ����
    bool isChasingPlayer = false;
    bool isAngry = false;
    [SerializeField] public Transform target;

    void Start()
    {
    }

    void Update()
    {

    }


    //�÷��̾�� soundPosition�� �޾ƿ��� �Լ�
    public void HearSound(Vector3 soundPosition)
    {
        lastHeardSoundPosition = soundPosition;
        isInvestigatingSound = true;
    }


}