using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum State 
{
    WALK,
    ATTACK,
    DIE
}

public class DogKnight : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] State state;
    [SerializeField] float speed = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        state = State.WALK;
    }

    // Update is called once per frame
    void Update()
    {
        switch (state) 
        {
            case State.WALK:
                Walk();
                break;
            case State.ATTACK:
                Attack(); 
                break;
            case State.DIE:
                Die(); 
                break;
        }
    }

    public void Walk()
    {
        Debug.Log("Walk");

        animator.SetBool("Attack", false);

        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    public void Attack()
    {
        Debug.Log("Attack");

        animator.SetBool("Attack", true);
    }

    public void Die()
    {
        Debug.Log("Die");

        animator.Play("Die");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");

        if (other.gameObject.CompareTag("Enemy"))
        {
            state = State.ATTACK;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("OnTriggerStay");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("OnTriggerExit");

        if (other.gameObject.CompareTag("Enemy"))
        {
            state = State.DIE;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // �������� �浹�� �Ͼ�� �� ȣ��Ǵ� �̺�Ʈ �Լ��̴�.

        // Debug.Log("OnCollisionEnter");

    }

    private void OnCollisionStay(Collision collision)
    {
        // �������� �浹�� �ϰ� �ִ� ���� �� ȣ��Ǵ� �̺�Ʈ �Լ��̴�.

        // Debug.Log("OnCollisionStay");

    }

    private void OnCollisionExit(Collision collision)
    {
        // �������� �浹�� ������ �� ȣ��Ǵ� �̺�Ʈ �Լ��̴�.

        // Debug.Log("OnCollisionExit");

    }
}
