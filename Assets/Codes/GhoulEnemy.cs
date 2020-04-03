using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhoulEnemy : EnemieParent {

	Color _color;
	bool _redo;
	public Rigidbody Enemy;

	public GhoulEnemy(float xspeed, float yspeed)
	{
		x_speed = xspeed;
		y_speed = yspeed;
	}

	void Start () {
		Enemy = GetComponent<Rigidbody>();
		_color = gameObject.GetComponent<Renderer>().material.color;
		_redo = false;
	}

	void Plus()
	{
		_color.a += 0.01f;
		gameObject.GetComponent<Renderer>().material.color = _color;
	}
	void Minus()
	{
		_color.a -= 0.01f;
		gameObject.GetComponent<Renderer>().material.color = _color;
	}

	void ChangeColor()
	{
		if(_color.a > 0 && _redo == false)
		{
			Minus();
		} else if(_color.a < 1)
		{
			_redo = true;
		}
		if(_color.a < 1 && _redo)
		{
			Plus();
		} else if(_color.a == 1)
		{
			_redo = false;
		}
	}
	
	public void Move () 
	{
		Enemy.MovePosition(Enemy.transform.position + Enemy.transform.forward * x_speed + Enemy.transform.right * -(y_speed));
	}

	void FixedUpdate () {
		ChangeColor();
		Move();
	}
}
