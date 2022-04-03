using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullHealPickup : Pickup
{
    // full heals the player
    public override void DoOnPickup(Collider2D collision)
    {
       if(collision.tag == "Player" && collision.gameObject.GetComponent<Health>() != null)
        {
            Health playerhealth = collision.gameObject.GetComponent<Health>();
            if(playerhealth.currentHealth<playerhealth.maximumHealth)
            {
                playerhealth.ReceiveHealing(playerhealth.maximumHealth);
                base.DoOnPickup(collision);

            }
        }
    }
}
