using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class shooting : MonoBehaviour {
    public float damadge = 10f;
    public float range = 100f;
    public float firerate = 15f;
    public Camera fbscam;
    public GameObject impacteffect;
    public ParticleSystem muzzleflash;
    public int maxammo = 10;
    private int currentammo;
    public float reloadtime = 1f;
    private bool isreloading = false;
    public Animator animator;
	 
    // Use this for initialization
    
    
    private float nexttimetofire = 0f;

    void start()
    {
        if (currentammo == -1)
            currentammo = maxammo;
    
    
    }

    void OnEnable()
    {
        isreloading = false;
        animator.SetBool("reloading", false);
    }
    
    
    
   
	void Update () {
        if (isreloading)
            return;
        
        
        
        if (currentammo <= 0)
        {
            StartCoroutine(reload());
            return;
        }
        
        if (Input.GetButtonDown("Fire1") && Time.time >= nexttimetofire) 
        {
            nexttimetofire = Time.time + 1f / firerate;
            shoot();
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
        if (Physics.Raycast(fbscam.transform.position, fbscam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            target target = hit.transform.GetComponent<target>();
            if (target != null)
            {
                target.takedamadge(damadge);
            }

            Instantiate(impacteffect, hit.point, Quaternion.LookRotation(hit.normal));
        }
    }


}

