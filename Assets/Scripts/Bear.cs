using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//*** This script inheritants from Item, and sets the reaction, intake, and karma the player will get***//
public class Bear : Item
{
    public override void UseItem()
    {
        reaction.text = "Ouch! Your Hurt me!";
        intake += -1;
        karma += -20;
        base.UseItem();
    }
}
