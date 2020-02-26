using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotGun : RayCastWeapon
{

    public Vector3 Spread = new Vector3(0.1f, 0, 0);

    public override void Fire(Vector3 fireFromPosition)
    {
        ShootRay(fireFromPosition,transform.forward);
        ShootRay(fireFromPosition,transform.forward + Spread);
        ShootRay(fireFromPosition, transform.forward - Spread);
        base.Fire(fireFromPosition);    
    }

    private void ShootRay(Vector3 position,Vector3 direction)
    {
        if (Physics.Raycast(position,direction, out raycastHit, Range))
        {
            HealthComponent health = raycastHit.collider.GetComponent<HealthComponent>();
            if (health)
            {
                health.ApplyDamage(DamagePerHit);
            }

        }
    }
}
