using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f;
    private Rigidbody bulletRigidbody;
   
    void Start()
    {  
        bulletRigidbody=GetComponent<Rigidbody>();
        //���� ������Ʈ���� rigidbidy������Ʈ�� ã�� �Ҵ�
        bulletRigidbody.velocity=transform.forward*speed;
        //������ٵ��� �ӵ� =���ʹ��� * �̵� �ӷ� 
        //transform�� �ڽ��� Ʈ������ ������Ʈ�� �ٷ������ϴ� ����
        Destroy(gameObject, 3f);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
        {
            //���� ���� ������Ʈ���� PlyaerController ������Ʈ ��������
            PlayerController plyaerController=other.GetComponent<PlayerController>();

            //�������κ��� playercontrolloer ������Ʈ�� �������� �� �����ߴٸ�
            if(plyaerController!=null)
            {
                plyaerController.Die();
            }

        }
    }

}
