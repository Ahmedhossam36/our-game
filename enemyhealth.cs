using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthofplayer : MonoBehaviour {
	public float health = 100f;
	public void takedamadge(float amount)
	{
		health -= amount;
		if (health <= 0f)
		{
			DIE();
		}
	}
	void DIE()
	{
		Destroy(gameObject);
	}



}
