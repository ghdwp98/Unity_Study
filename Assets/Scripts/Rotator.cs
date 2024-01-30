using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotaionSpeed = 60f;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(0f, rotaionSpeed, 0f);
    }
}
