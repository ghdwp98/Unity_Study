using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody playerRigidbody;
    public float speed = 8f;
    void Start()
    {
        playerRigidbody=GetComponent<Rigidbody>();
    }


    void Update()
    {   //수평축과 수직축의 입력값을 감지하여 저장 
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        //실제 이동 속도를 입력값과 이동 속력을 사용해 결정 
        float xSpeed=xInput*speed;
        float zSpeed=zInput*speed;

        Vector3 newVelocity=new Vector3(xSpeed,0,zSpeed);
        playerRigidbody.velocity = newVelocity;
    }
    public void Die()
    {
        //자신의 게임 오브젝트를 비활성화
        gameObject.SetActive(false);
        GameManager gameManger=FindObjectOfType<GameManager>();
        gameManger.EndGame();
    }
}
