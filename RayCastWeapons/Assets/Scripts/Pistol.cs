using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : RayCastWeapon
{

    public override void Fire(Vector3 fireFromPosition)
    {
     
        if (Physics.Raycast(fireFromPosition,transform.forward,out raycastHit, Range))
        {
            HealthComponent health = raycastHit.collider.GetComponent<HealthComponent>();
            if (health)
            {
                health.ApplyDamage(DamagePerHit);
            }

        }
        base.Fire(fireFromPosition);
    }
}
