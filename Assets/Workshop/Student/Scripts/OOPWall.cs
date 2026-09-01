using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

// OOPWall aka "Demon Wall"
public class OOPWall : Identity
{
    public int damage = 5;

    public override void Hit()
    {
        base.Hit();
        mapGenerator.player.TakeDamage(damage);
        mapGenerator.mapdata[positionX, positionY] = mapGenerator.empty;
        Destroy(gameObject);

    }
    
}