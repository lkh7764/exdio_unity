using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody bulletRigidbody;
    public float speed = 8f;
    
    // Start is called before the first frame update
    void Start()
    {
        //게임 오브젝트에서 Rigidbody 컴포넌트를 찾아 bulletRigidbody에 할당
        bulletRigidbody = GetComponent<Rigidbody>();
        //리지드바디의 속도 = 앞쪽 방향 * 이동 속력
        bulletRigidbody.velocity = transform.forward * speed;

        //3초 뒤에 자신의 게임 오브젝트 파괴
        Destroy(gameObject, 3f);
    }

    //OnTrigger계열 (Enter, Stay, Exit): 둘 중 하나라도 트리거 콜라이더인 경우 실행
        //Enter: 콜라이더가 접촉했을 때
        //Stay: 콜라이더가 접촉하는 동안
        //Exit: 콜라이더가 접촉이 끝나는 순간

    //OnCollision계열 (Enter, Stay, Exit): 둘 다 Collision 콜라이더인 경우에만 실행 
        //Enter: 콜라이더가 접촉했을 때
        //Stay: 콜라이더가 접촉하는 동안
        //Exit: 콜라이더가 접촉이 끝나는 순간


    //트리거 충돌 시 자동으로 실행되는 메서드
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerController playerController = other.GetComponent<PlayerController>();
        
            if (playerController != null)
            {
                playerController.Die();
            }
        }
    }

}
