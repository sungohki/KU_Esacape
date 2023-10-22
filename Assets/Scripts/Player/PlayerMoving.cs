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

        if (Input.GetKey(KeyCode.LeftShift))
        {
            playerSpd *= 1.5f;      // Player Running

            SecurityMoving securityGuard = FindObjectOfType<SecurityMoving>();  // Security Object ref
            if (securityGuard != null)
                // Running Sound Occur & Transmission sound position
                securityGuard.HearSound(transform.position);
        }
        dir = new Vector3(playerH, 0, playerV) * playerSpd;
        transform.rotation = Quaternion.Euler(0, Mathf.Atan2(playerH, playerV) * Mathf.Rad2Deg, 0); // Handle "rotation"
        cc.Move(dir * Time.deltaTime);     // Handle "movement"
    }
}
