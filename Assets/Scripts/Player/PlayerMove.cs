using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    PlayerStat playerStat = new PlayerStat();

    // Movement Func
    void PlayerBasicMovement() {
        // 플레이어의 입력을 받아 이동 벡터를 계산
        float horizontalInput = Input.GetAxis("Horizontal"); // 수평 입력
        float verticalInput = Input.GetAxis("Vertical");     // 수직 입력
        
        Vector3 movement = new Vector3(horizontalInput, 0.0f, verticalInput);

        // 이동 벡터의 길이를 1로 정규화 후 속도를 곱해서 최종 이동 벡터 반환
        movement.Normalize();

        // 기본 움직임
        movement *= playerStat.getPlayerMoveSpeed() * Time.deltaTime;
        // 달리기 
        if (Input.GetKey(KeyCode.LeftShift))
            movement *= playerStat.getPlayerAddSpeed();

        // 현재 위치에 이동 벡터를 더하여 이동합니다.
        transform.Translate(movement);
    }

    // Add Speed Func
}
