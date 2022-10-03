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
        //���� ������Ʈ���� Rigidbody ������Ʈ�� ã�� bulletRigidbody�� �Ҵ�
        bulletRigidbody = GetComponent<Rigidbody>();
        //������ٵ��� �ӵ� = ���� ���� * �̵� �ӷ�
        bulletRigidbody.velocity = transform.forward * speed;

        //3�� �ڿ� �ڽ��� ���� ������Ʈ �ı�
        Destroy(gameObject, 3f);
    }

    //OnTrigger�迭 (Enter, Stay, Exit): �� �� �ϳ��� Ʈ���� �ݶ��̴��� ��� ����
        //Enter: �ݶ��̴��� �������� ��
        //Stay: �ݶ��̴��� �����ϴ� ����
        //Exit: �ݶ��̴��� ������ ������ ����

    //OnCollision�迭 (Enter, Stay, Exit): �� �� Collision �ݶ��̴��� ��쿡�� ���� 
        //Enter: �ݶ��̴��� �������� ��
        //Stay: �ݶ��̴��� �����ϴ� ����
        //Exit: �ݶ��̴��� ������ ������ ����


    //Ʈ���� �浹 �� �ڵ����� ����Ǵ� �޼���
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
