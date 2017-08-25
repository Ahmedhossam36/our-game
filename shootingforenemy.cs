using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootingforenemy : MonoBehaviour {
	public float damadge = 10f;
	public float range = 100f;
	public float firerate = 15f;
	public GameObject impacteffect;
	public ParticleSystem muzzleflash;
	public int maxammo = 10;
	private int currentammo;
	public float reloadtime = 1f;
	private bool isreloading = false;
	public Animator animator;
	// Use this for initialization
	private float nexttimetofire = 0f;


	public float distance = 100f; 
	public float attackrange = 30f; 
	public Transform target ;
	public follow AI ;


	void Start () {
		if (currentammo == -1)
			currentammo = maxammo;
		
	}
	void OnEnable()
	{
		isreloading = false;
		animator.SetBool("reloading", false);
	}

	// Update is called once per frame
	void Update () {
		distance = Vector3.Distance (target.position, transform.position);

		if (distance < attackrange) {
			transform.LookAt (target);
			transform.Translate (transform.forward * 0f * Time.deltaTime);
			shoot ();
		}
		if (distance > attackrange) {
			AI.enabled = true;
		}
			
			


		if (isreloading)
			return;



		if (currentammo <= 0)
		{
			StartCoroutine(reload());
			return;
		}



	}

	IEnumerator reload()
	{
		isreloading = true;
		Debug.Log("Reloading....");
		animator.SetBool("reloading", true);
		yield return new WaitForSeconds(reloadtime - .25f);
		animator.SetBool("reloading", false);
		yield return new WaitForSeconds(.25f);
		currentammo = maxammo;
		isreloading = false;
	}
	void shoot()
	{
		muzzleflash.Play();
		currentammo--;
		RaycastHit hit;
		if (Physics.Raycast(target.position, target.transform.forward, out hit, range))
		{
			Debug.Log(hit.transform.name);
			healthofplayer player = hit.transform.GetComponent<healthofplayer>();
			if (player!= null)
			{
				player.takedamadge(damadge);
			}

			Instantiate(impacteffect, hit.point, Quaternion.LookRotation(hit.normal));
		}
	}
}

