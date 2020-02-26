using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {

    public Weapon[] weapons;
    int activeWeaponIndex = -1;
    Weapon activeWeapon;
	void Start ()
    {
        SetActiveWeapon(0);
	}
	
	void Update ()
    {
        HandleWeaponSwitching();
        if (Input.GetButtonDown("Fire1"))
        {
            if (activeWeapon)
            {
                activeWeapon.Fire(transform.position);

            }
        }
       

		
	}



    private void HandleWeaponSwitching()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SetActiveWeapon(0);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SetActiveWeapon(1);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SetActiveWeapon(2);
        }



    }

    private void SetActiveWeapon(int index)
    {
        if (index >= 0 && index <= weapons.Length)
        {
            if (activeWeapon)
            {
                Destroy(activeWeapon.gameObject);
            }

                activeWeapon = Instantiate(weapons[index], transform);
                activeWeaponIndex = index;
            
        }
    }
}
