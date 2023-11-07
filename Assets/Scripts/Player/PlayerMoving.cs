using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoving : MonoBehaviour
{
    PlayerStat playerStat;
    Vector3 dir;
    CharacterController cc;
    private float playerSpd;


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

        if (Input.GetKeyDown(KeyCode.LeftShift)) {
            playerSpd = playerStat.getPlayerMoveSpeed() * 1.5f;      // Player Running

            SoundOccur();
        }

        if (Input.GetKeyUp(KeyCode.LeftShift)) {
            playerSpd = playerStat.getPlayerMoveSpeed();
        }

        dir = new Vector3(playerH, 0, playerV) * playerSpd;

        if (dir.magnitude > 0)
        {
            transform.rotation = Quaternion.Euler(0, Mathf.Atan2(playerH, playerV) * Mathf.Rad2Deg, 0);
        }

        cc.Move(dir * Time.deltaTime);     // Handle "movement"
    }

    public void SoundOccur() {
        SecurityMoving securityGuard = FindObjectOfType<SecurityMoving>();  // Security Object ref

        if (securityGuard != null)
            securityGuard.HearSound(transform.position);
    }
}
