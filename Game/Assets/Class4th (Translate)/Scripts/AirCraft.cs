using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirCraft : MonoBehaviour
{
    [SerializeField] Vector3 direction;
    [SerializeField] float speed = 1.0f;

    void Start()
    {
        
    }

    void Update()
    {
        // Debug.Log(Time.deltaTime);
        //                      -1 ~ 1
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");

        // 벡터의 정규화
        direction.Normalize();

        // P = P0 + v * t
        // Time.deltaTime : 마지막 프레임이 완료된 후 경과한 시간을 초 단위로 반환하는 값이다.
        transform.position = transform.position + direction * speed * (Time.deltaTime);
    }
}
