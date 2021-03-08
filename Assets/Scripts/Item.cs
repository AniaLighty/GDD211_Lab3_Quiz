using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//*** Base script that all in scene items inheritant from ***//
public class Item : MonoBehaviour
{
    public TMP_Text reaction; //<- What the game wull say when the player clicks on and item
    public TMP_Text stats; // <- States the player's health stats
    public static int intake;
    public static int karma;

    // Start is called before the first frame update
    void Start()
    {
        intake = 0;
        karma = 0;
        reaction.text = "Hi Player, make sure you eat.";
        stats.text = "";
    }

    //Triggers the UseItem() funtion
    private void OnMouseDown()
    {
        UseItem();
    }

    //What happens when the player click on and item
    public virtual void UseItem()
    {
        stats.text = "Your current caloric intake is " + intake + " and your karma is " + karma + ".";

        //Check to see if the player is dead
        if (intake < 0)
        {
            stats.text = "You should have eaten more...\nYou died\nFinal score\nIntake: " +intake+ " Karma: " +karma;
        }
    }
}
