using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtTarget : MonoBehaviour
{
    public Transform target;
    public float moveSpeed = 5f;
    public GameObject cat_OD;

    public Animator animator;

    private void Update()
    {
        if (target == null)
        {
            Debug.LogError("타겟 오브젝트가 지정되지 않았습니다.");
            return;
        }

        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion targetRotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * moveSpeed);

        // 이동 및 애니메이션 제어
        if (direction.magnitude > 0.5f) // 움직이는 중
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
            animator.SetBool("Walking", true); // "Walking" 파라미터를 true로 설정하여 걷는 애니메이션 재생
            cat_OD.SetActive(true);
        }
        else // 멈춰 있는 상태
        {
            animator.SetBool("Walking", false); // "Walking" 파라미터를 false로 설정하여 멈춘 상태의 애니메이션 재생
            moveSpeed = 0f;
            cat_OD.SetActive(false);
        }
    }
}