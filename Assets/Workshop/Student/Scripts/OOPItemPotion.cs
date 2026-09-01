using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OOPItemPotion : Identity
{
    public int healhPoint = 20;


    public override void Hit()
    {
        mapGenerator.player.Heal(20);
        Debug.Log("You got "+ Name + " : "  + healhPoint);
        mapGenerator.mapdata[positionX, positionY] = mapGenerator.empty;
        Destroy(gameObject);

    }



}