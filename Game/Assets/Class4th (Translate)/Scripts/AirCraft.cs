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

        // ������ ����ȭ
        direction.Normalize();

        // P = P0 + v * t
        // Time.deltaTime : ������ �������� �Ϸ�� �� ����� �ð��� �� ������ ��ȯ�ϴ� ���̴�.
        transform.position = transform.position + direction * speed * (Time.deltaTime);
    }
}
