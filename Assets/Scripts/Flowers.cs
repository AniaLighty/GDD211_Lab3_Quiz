using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//*** This script inheritants from Item, and sets the reaction, intake, and karma the player will get***//
public class Flowers : Item
{
    public override void UseItem()
    {
        reaction.text = "Not food, but has some form of medical use.";
        intake += -2;
        karma += 10;
        base.UseItem();
    }
}
