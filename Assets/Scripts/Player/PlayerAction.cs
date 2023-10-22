using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAction : MonoBehaviour
{
    void Update() {
        PlayerAttack();
        PlayerDamaged();
        PlayerSoundOccur();
        PlayerInteraction();
    }

    // Attack Func
    void PlayerAttack() {
        // 공격키를 입력하는 경우
        if(Input.GetKey(KeyCode.Space)) {
            // TODO: Add Attack Motion

            // playerAttackRange 내에 NPC 객체가 있는 경우
        }
    }

    // Damage Func
    void PlayerDamaged() {
        // playerDamageRange 내에 NPC 객체가 있는 경우
        if (true) {
            PlayerSoundOccur();
        }
    }

    // Sound Occur Func
    void PlayerSoundOccur() {
        // playerSoundRange 범위의 영역 생성
    }

    // Interaction Obj func
    void PlayerInteraction() {
        if (Input.GetKey(KeyCode.J)) {}
    }

}
