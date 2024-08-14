using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : MonoBehaviour
{
    [SerializeField] Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (animator.GetCurrentAnimatorStateInfo(0).IsName("Run") == false)
            {
                animator.SetTrigger("Run");
            }
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            if (animator.GetCurrentAnimatorStateInfo(0).IsName("Standing Idle") == false)
            {
                animator.SetTrigger("Idle");
            }
        }
    }
}
