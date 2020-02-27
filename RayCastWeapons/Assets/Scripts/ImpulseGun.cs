using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpulseGun : RayCastWeapon
{

    public float ImpulseAmount = 10;

    public override void Fire(Vector3 fireFromPosition)
    {

        if (Physics.Raycast(fireFromPosition, transform.forward, out raycastHit, Range))
        {
            Rigidbody health = raycastHit.collider.GetComponent<Rigidbody>();
            if (health)
            {
                Vector3 direcetion = transform.position - health.transform.position;
                health.AddForce(-direcetion * ImpulseAmount, ForceMode.Impulse);
            }
        }

            base.Fire(fireFromPosition);
     
    }
}
