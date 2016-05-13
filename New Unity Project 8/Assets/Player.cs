﻿using UnityEngine;
using System.Collections;
public enum ePlayer
{
Left,
Right
}
public class Player : MonoBehaviour {
    public float speed = 15f;
    public ePlayer player;
	void Update () {
        float inputSpeed = 0f;
        if (player == ePlayer.Left)
        {
            inputSpeed = Input.GetAxisRaw("PlayerLeft");
        }
        else if (player == ePlayer.Right)
        {
            inputSpeed = Input.GetAxisRaw("PlayerRighr");
        }
        transform.position += new Vector3(0f, 0f, inputSpeed * speed * Time.deltaTime);
	}
}
