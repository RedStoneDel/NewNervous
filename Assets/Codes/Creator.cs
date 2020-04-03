using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creator : MonoBehaviour {
	
	public int EnemiesOnMap;
	public GameObject[] Classes = new GameObject[1];
	
	public int[] Count = new int[1];
	public int Index = 0;

    public void Creation()
	{
		if(EnemiesOnMap < Count.Length * Classes.Length){
			for(int i = 0; i < Classes.Length; i++)
			{
				Index++;
				for(int a = 0; a < Count[Index-1]; a++)
				{
					Instantiate(Classes[Index-1]);
					EnemiesOnMap++;
				}
			}
		}
	}
	public void FixedUpdate()
	{
		Creation();
	}

}
