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
        var h = Input.GetAxis("Horizontal");
        var v = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.LeftShift))
        {
            playerSpd *= 1.5f;      // Player Running

            SecurityMoving securityGuard = FindObjectOfType<SecurityMoving>();  // Security Object ref
            if (securityGuard != null)
                // Running Sound Occur & Transmission sound position
                securityGuard.HearSound(transform.position);
        }
        dir = new Vector3(h, 0, v) * playerSpd;
        transform.rotation = Quaternion.Euler(0, Mathf.Atan2(h, v) * Mathf.Rad2Deg, 0); // Handle "rotation"
        cc.Move(dir * Time.deltaTime);     // Handle "movement"
    }
}
