using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//*** This script inheritants from Item, and sets the reaction, intake, and karma the player will get***//
public class Orb : Item
{
    public override void UseItem()
    {
        reaction.text = "CRUNCH!";
        intake += 100;
        karma += 30;
        base.UseItem();
    }
}
