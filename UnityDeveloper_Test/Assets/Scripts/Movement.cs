using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class Movement : MonoBehaviour
{
    public float speed = 5.0f;
    private Animator animator;
    public float rotationSpeed = 720f;
    //private Rigidbody rb;

    void Start()
    {
        animator = GetComponent<Animator>();
        
    }
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 moveDirection = new Vector3(horizontal, 0.0f, vertical).normalized;

        if (moveDirection.magnitude >= 0.1f)
        {
            Vector3 move = transform.right * moveDirection.x + transform.forward * moveDirection.z;
            transform.position += move * speed * Time.deltaTime;
            float targetAngle = Mathf.Atan2(moveDirection.x, moveDirection.z) * Mathf.Rad2Deg + transform.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref rotationSpeed, 0.1f);
            transform.rotation = Quaternion.Euler(0, angle, 0);
        }
        animator.SetFloat("speed", moveDirection.magnitude);
        Debug.Log(moveDirection.magnitude);
    }
}
