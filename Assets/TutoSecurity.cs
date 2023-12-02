using System.Collections;
using UnityEngine;

public class TutoSecurity : MonoBehaviour
{

    Vector3 lastHeardSoundPosition; //sound 발생 위치 저장할 변수
    bool isInvestigatingSound = false; //sound 발생 위치 조사 중인지 여부
    bool isChasingPlayer = false;
    bool isAngry = false;
    [SerializeField] public Transform target;

    void Start()
    {
    }

    void Update()
    {

    }


    //플레이어에서 soundPosition을 받아오는 함수
    public void HearSound(Vector3 soundPosition)
    {
        lastHeardSoundPosition = soundPosition;
        isInvestigatingSound = true;
    }


}