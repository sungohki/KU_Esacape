using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMoving : MonoBehaviour
{
    PlayerStat playerStat;
    Vector3 dir;
    CharacterController cc;
    private float playerSpd;
    private float rotationSpeed = 100f;
    public Image uiImage;


    void Start()
    {
        cc = GetComponent<CharacterController>();       // add Ref of Character Controller
        playerStat = GameObject.FindAnyObjectByType<PlayerStat>();
        playerSpd = playerStat.getPlayerMoveSpeed();    // set Player Speed
    }

    void Update()
    {
        var playerH = Input.GetAxis("Horizontal");
        var playerV = Input.GetAxis("Vertical");

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            playerSpd = playerStat.getPlayerMoveSpeed() * 1.5f; // Player Running
            SoundOccur();
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            playerSpd = playerStat.getPlayerMoveSpeed();
        }

        // 이동 관련 코드
        float moveDirection = playerV;
        if (moveDirection < 0) // 뒤로 이동하는 경우
        {
            dir = transform.TransformDirection(Vector3.back) * Mathf.Abs(moveDirection) * playerSpd;
        }
        else if (moveDirection > 0) // 앞으로 이동하는 경우
        {
            dir = transform.TransformDirection(Vector3.forward) * moveDirection * playerSpd;
        }
        else
        {
            dir = Vector3.zero;
        }

        cc.Move(dir * Time.deltaTime); // Handle "movement"

        // A와 D 키로 플레이어 회전
        if (playerH != 0)
        {
            transform.Rotate(Vector3.up, playerH * rotationSpeed * Time.deltaTime);
        }
    }

    public void SoundOccur()
    {
        SecurityMoving securityGuard = FindObjectOfType<SecurityMoving>();  // Security Object ref

        if (securityGuard != null)
            securityGuard.HearSound(transform.position);

        {
            // SoundOccur가 호출되었을 때 UI Image를 활성화
            uiImage.gameObject.SetActive(true);

            Invoke("DisableImage", 1f);
        }
    }

    private void DisableImage()
    {
        if (uiImage != null)
        {
            // 일정 시간(1초 후)에 UI Image를 비활성화
            uiImage.gameObject.SetActive(false);
        }
    }
}
