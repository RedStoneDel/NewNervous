using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemieParent : MonoBehaviour 
{

	public float x_speed;
	public float y_speed;

	void OnTriggerEnter(Collider Other)
	{
		if(Other.tag == "XWalls"){
			x_speed *= -1;
			return;
		}
		if(Other.tag == "YWalls"){
			y_speed *= -1;
			return;
		} 
		if(Other.tag == "Enemy"){
			x_speed *= -1;
			y_speed *= -1;
		}
	}
	
}