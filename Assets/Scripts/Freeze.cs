using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freeze : Pickup
{


    public override void Activate()
    {
        Enemy.speed = 0;
    }
}
