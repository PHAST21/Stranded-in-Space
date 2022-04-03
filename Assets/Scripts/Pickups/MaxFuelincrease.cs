using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaxFuelincrease : Pickup
{ 
    public override void DoOnPickup(Collider2D collision)
    {
        if (collision.tag == "Player" && collision.gameObject.GetComponent<PlayerController>() != null)
        {
            PlayerController Maxfuel = collision.gameObject.GetComponent<PlayerController>();
            Maxfuel.maxfuel = Maxfuel.maxfuel + 20;
            base.DoOnPickup(collision);

        }

    }

}
