using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power : Pickup
{
    public override void Activate()
    {
        Player.poweredUp = true;
    }
}
