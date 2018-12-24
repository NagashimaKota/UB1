using UnityEngine;
using System.Collections;

public class game : MonoBehaviour {

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

        //地面についてるかどうか
        if (controller.isGrounded)
        {
            //移動方向を取得
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;

            //ジャンプ
            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }
        }

        // 重力を計算
        moveDirection.y -= gravity * Time.deltaTime;

        // 移動
        controller.Move(moveDirection * Time.deltaTime);


    }
}
