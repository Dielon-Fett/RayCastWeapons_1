using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpulseGun : RayCastWeapon
{

    public float ImpulseAmount = 10;

    public override void Fire(Vector3 fireFromPosition)
    {
        base.Fire(fireFromPosition);
        if (raycastHit.rigidbody)
        {
           
          
        }
    }
}
