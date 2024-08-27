using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Character : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] UnityEvent unityEvent;

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
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Walk"))
        {
            if (animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1.0f)
            {
                // Debug.Log(animator.GetCurrentAnimatorStateInfo(0).normalizedTime);

                // 참조 형식의 변수는 null check가 중요
                if (unityEvent != null)
                {
                    unityEvent.Invoke();
                }

                // animation 초기화
                animator.Rebind();
                // Debug.Log(animator.GetCurrentAnimatorStateInfo(0).normalizedTime);
            }
        }
    }
}
