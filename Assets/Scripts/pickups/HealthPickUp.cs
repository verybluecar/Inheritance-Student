using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickUp : PickUp
{
    public float HealValue;

    public override void ActivatePickUp()
    {
        player.health += HealValue;
        if (player.health > player.maxHealth)
        {
            player.health = player.maxHealth;
        }

        Destroy(gameObject);
    }
}
