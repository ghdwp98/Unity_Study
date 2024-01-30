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
        //게임 오브젝트에서 rigidbidy컴포넌트를 찾아 할당
        bulletRigidbody.velocity=transform.forward*speed;
        //리지드바디의 속도 =앞쪽방향 * 이동 속력 
        //transform은 자신의 트랜스폼 컴포넌트로 바로접근하는 변수
        Destroy(gameObject, 3f);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
        {
            //상대방 게임 오브젝트에서 PlyaerController 컴포넌트 가져오기
            PlayerController plyaerController=other.GetComponent<PlayerController>();

            //상대방으로부터 playercontrolloer 컴포넌트를 가져오는 데 성공했다면
            if(plyaerController!=null)
            {
                plyaerController.Die();
            }

        }
    }

}
