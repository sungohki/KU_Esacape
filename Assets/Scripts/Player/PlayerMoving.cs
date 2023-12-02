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

        // �̵� ���� �ڵ�
        float moveDirection = playerV;
        if (moveDirection < 0) // �ڷ� �̵��ϴ� ���
        {
            dir = transform.TransformDirection(Vector3.back) * Mathf.Abs(moveDirection) * playerSpd;
        }
        else if (moveDirection > 0) // ������ �̵��ϴ� ���
        {
            dir = transform.TransformDirection(Vector3.forward) * moveDirection * playerSpd;
        }
        else
        {
            dir = Vector3.zero;
        }

        cc.Move(dir * Time.deltaTime); // Handle "movement"

        // A�� D Ű�� �÷��̾� ȸ��
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
            // SoundOccur�� ȣ��Ǿ��� �� UI Image�� Ȱ��ȭ
            uiImage.gameObject.SetActive(true);

            Invoke("DisableImage", 1f);
        }
    }

    private void DisableImage()
    {
        if (uiImage != null)
        {
            // ���� �ð�(1�� ��)�� UI Image�� ��Ȱ��ȭ
            uiImage.gameObject.SetActive(false);
        }
    }
}
