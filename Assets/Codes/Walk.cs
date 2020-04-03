using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : MonoBehaviour {
	public Rigidbody rb;
	public float speed = 20f;
	public float rotateSpeed;
	void Start () {
		 rb = GetComponent<Rigidbody>();
	}
	void FixedUpdate () {
		rb.MovePosition(rb.transform.position + rb.transform.right * -(Input.GetAxis("Horizontal")* speed) * Time.fixedDeltaTime + rb.transform.forward * -(Input.GetAxis("Vertical")* speed) * Time.fixedDeltaTime);
	}
}
