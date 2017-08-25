using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switching : MonoBehaviour
{
    public int SELECTEDWEAPON = 0;
    // Use this for initialization
    void Start()
    {
        SELECTWEAPON();
    }

    // Update is called once per frame
    void Update()
    {
        int PRIVIOUSSELECTEDWEAPON = SELECTEDWEAPON;
        if (Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            if (SELECTEDWEAPON >= transform.childCount - 1)
                SELECTEDWEAPON = 0;
            else
                SELECTEDWEAPON++;
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            if (SELECTEDWEAPON == 0)
                SELECTEDWEAPON = transform.childCount - 1;
            else
                SELECTEDWEAPON--;
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SELECTEDWEAPON = 0;
        }



        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SELECTEDWEAPON = 1;
        }













        if (PRIVIOUSSELECTEDWEAPON != SELECTEDWEAPON)
        {
            SELECTWEAPON();
        }
    }

    void SELECTWEAPON()
    {
        int I = 0;
        foreach (Transform weapon in transform)
        {
            if (I == SELECTEDWEAPON)
                weapon.gameObject.SetActive(true);
            else
                weapon.gameObject.SetActive(false);


            I++;
        }
    }
}