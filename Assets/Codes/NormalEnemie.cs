using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalEnemie : EnemieParent {

	public Rigidbody Enemy;

	public NormalEnemie(float xspeed, float yspeed)
	{
		x_speed = xspeed;
		y_speed = yspeed;
	}

	public void Start () 
	{
		Enemy = GetComponent<Rigidbody>();
	}
	
	public void Move () 
	{
		Enemy.MovePosition(Enemy.transform.position + Enemy.transform.forward * x_speed + Enemy.transform.right * -(y_speed));
	}

	void FixedUpdate()
	{
		Move();
	}
	
}
