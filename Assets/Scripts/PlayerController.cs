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
    {   //������� �������� �Է°��� �����Ͽ� ���� 
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        //���� �̵� �ӵ��� �Է°��� �̵� �ӷ��� ����� ���� 
        float xSpeed=xInput*speed;
        float zSpeed=zInput*speed;

        Vector3 newVelocity=new Vector3(xSpeed,0,zSpeed);
        playerRigidbody.velocity = newVelocity;
    }
    public void Die()
    {
        //�ڽ��� ���� ������Ʈ�� ��Ȱ��ȭ
        gameObject.SetActive(false);
        GameManager gameManger=FindObjectOfType<GameManager>();
        gameManger.EndGame();
    }
}
