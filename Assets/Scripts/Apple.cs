using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//*** This script inheritants from Item, and sets the reaction, intake, and karma the player will get***//
public class Apple : Item
{
    public override void UseItem()
    {
        reaction.text = "Sweet and good for your teeth!";
        intake += 50;
        karma += 0;
        base.UseItem();
    }
}
