using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Refueler : Pickup
{
    public override void DoOnPickup(Collider2D collision)
    {
        if (collision.tag == "Player" && collision.gameObject.GetComponent<PlayerController>() != null)
        {
            PlayerController Fuel = collision.gameObject.GetComponent<PlayerController>();
            if (Fuel.fuel < Fuel.maxfuel)
            {
                Fuel.fuel = Fuel.maxfuel;
                base.DoOnPickup(collision);

            }
        }
    }
}
