﻿using UnityEngine;
using System.Collections;

public class hako2 : MonoBehaviour {

    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;


    public Vector3 moveDirection = Vector3.zero;


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        CharacterController controller = GetComponent<CharacterController>();


        //移動方向を取得
        moveDirection = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection *= speed;


        // 移動
        controller.Move(moveDirection * Time.deltaTime);


    }
}
