using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //PlayerController스크립트에서 제어할 컴포넌트와 사용될 변수들을 선언
    private Rigidbody playerRigidbody;  //이동에 사용할 리지드바디 컴포넌트
    public float speed = 8f;    //이동 속력
    
    // Start is called before the first frame update
    void Start()
    {
        //게임 오브젝트에서 RigidBody 컴포넌트를 찾아 PlayerRigidbody에 할당
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //수평과 수직 축 입력 값을 감지하여 저장
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        //실제 이동 속도를 입력 값과 이동 속력을 통해 결정
        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        //Vector3 속도를 (xSpeed, 0, zSpeed)으로 생성
        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);

        //리지드바디의 속도에 newVelocity를 할당
        playerRigidbody.velocity = newVelocity;
    }

    public void Die()
    {
        //자신의 게임 오브젝트를 비활성화
        gameObject.SetActive(false);

        //씬에 존재하는 GameManager 타입의 오브젝트를 찾아서 가져오기
        GameManager gameManager = FindObjectOfType<GameManager>();
        gameManager.EndGame();
    }
}
