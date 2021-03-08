using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//*** This script inheritants from Item, and sets the reaction, intake, and karma the player will get***//
public class Bees : Item
{
    public override void UseItem()
    {
        reaction.text = "HEY, you can't eat us! Just our honey!";
        stats.text = "You got stung to death...";
        //base.UseItem();
    }
}
