using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour {
	public Transform target ;
	float speed = 10f;
	public float safedistance = 70f;
	public float distance = 100f; 
	public float attackrange = 50f; 
	private GameObject enemy;
	public follow AI ;
	public GameObject Bullet;
	public Transform Bulletspawn;
	public float timebetweenshots = 10f;
	private float timesstamp = 0f;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame






	void Update () {

		 distance = Vector3.Distance (target.position, transform.position);

		if (distance <= safedistance) {
			transform.LookAt (target);
			transform.Translate (-transform.forward * speed * Time.deltaTime);
		}	
		if (distance <= attackrange ) {
			transform.Translate (target.position - transform.position);

		}
			
	
	

}
}