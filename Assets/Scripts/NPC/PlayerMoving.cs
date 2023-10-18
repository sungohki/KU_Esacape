using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoving : MonoBehaviour
{
    Vector3 dir; //플레이어 이동 방향을 저장할 변수
    CharacterController cc; //라이브러리에 있던데 편리한듯

    [SerializeField] public float default_speed; //인스펙터에서 조절가능한 기초 스피드.
    private float now_speed; // 플레이어가 이동하는 이동속도.
    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>(); //캐릭터 컨트롤러에 대한 참조를 설정
        now_speed = default_speed; //이동속도 지정해주기.
    }

    // Update is called once per frame
    void Update()
    {
        var h = Input.GetAxis("Horizontal"); //입력값 가져오기
        var v = Input.GetAxis("Vertical"); //입력값 가져오기

        if (Input.GetKey(KeyCode.LeftShift)) //왼쉬프트 눌렀을때
        {
            now_speed = default_speed * 1.5f; //두배로~
        }

        else
        {
            now_speed = default_speed; //아닐땐 그냥
        }


        dir = new Vector3(h, 0, v) * now_speed; //이동방향 설정

        transform.rotation = Quaternion.Euler(0, Mathf.Atan2(h, v) * Mathf.Rad2Deg, 0); //회전처리

        cc.Move(dir * Time.deltaTime); //이동처리

    }
}
