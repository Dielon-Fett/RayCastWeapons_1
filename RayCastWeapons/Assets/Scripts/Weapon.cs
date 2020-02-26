using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    public int MaxReserves;
    public int Reserves;

    public int MaxMagazine;
    public int Magazine;

    public int AmmoUserPerShot;
    public bool IsAutomatic;
	void Start ()
    {
        Magazine = MaxMagazine;
        Reserves = MaxReserves;
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public virtual void Fire(Vector3 fireFromPosition)
    {
        Magazine -= AmmoUserPerShot;
        if (Magazine <= 0)
        {
            Reload();
        }
    }

    public bool HasAmmo()
    {
        return Magazine >= AmmoUserPerShot;
     
    }

    public void Reload()
    {
        if (Reserves >= MaxMagazine)
        {
            Magazine = MaxMagazine;
            Reserves -= MaxMagazine;
        }
        else
        {
            Magazine = Reserves;
            Reserves = 0;
        }
    }
}
