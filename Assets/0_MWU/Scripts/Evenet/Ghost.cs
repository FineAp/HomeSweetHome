using UnityEngine;

public class Ghost : MonoBehaviour
{
    public Transform target;  // 따라갈 대상 물체
    public float moveSpeed = 5.0f;  // 이동 속도
    

    private void Update()
    {
        if (target != null)
        {
            Vector3 targetDirection = target.position - transform.position;
            Vector3 moveDirection = targetDirection.normalized;

            // 대상 물체를 향해 이동
            transform.position += moveDirection * moveSpeed * Time.deltaTime;

            // 물체를 바라보도록 회전
            transform.rotation = Quaternion.LookRotation(targetDirection, Vector3.up);
        }


    }
}