using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class holds all the logic for our stats system, so that includes logic to handle generating starting physical stats
/// calculating our dancing stats based on physical stats and our stat multipliers.
/// </summary>
public class StatsSystem : MonoBehaviour
{
    /// Our physical stats that determine our dancing stats.
    public int strength;
    public int agility;
    public int intelligence;
    public int statPool = 21;

    // Our variables used to determine our fighting power.
    public int style;
    public int luck;
    public int rhythm;

    private void Start()
    {
        // set out agility, strength and intelligence to a random number between zero and ten.
        // BONUS! let's try taking our stats away from a pool of stats, i.e. 20 total, distributing this amoungst all the stats.
        Debug.Log("CHARACTER STATS:");

        strength = Random.Range(0, statPool);
        agility = Random.Range(0, statPool - strength);
        intelligence = Random.Range(0, statPool - strength - agility);

        // Debug out your current physical stat values (strength, agility, intelligence).
        Debug.Log("Player strength is " + strength);
        Debug.Log("Player agility is " + agility);
        Debug.Log("Player intelligence is " + intelligence);

        // let's create some float temporary variables to hold our multiplier values.

        // create a strength multiplier should be set to 1
        float strengthMult = 1.0f;

        // create an agility multiplier should be set to 0.5
        float agilityMult = 0.5f;      

        // create an intelligence multiplier should be set to 2.
        float intelligenceMult = 2.0f;

        // Debug out our current multiplier values.
        Debug.Log("Strength multiplier is set to 1");
        Debug.Log("Agility multiplier is set to 0.5");
        Debug.Log("Intelligence multiplier is set to 2");

        // now that we have some stats and our multiplier values let's calculate our style, luck and ryhtmn based on these values.
        // style should be based off our strength and be converted at a rate of 1 : 1.
        float style = strength * strengthMult;
        // luck should be based off our intelligence and be converted at a rate of 1 : 1.5f
        float luck = agility * agilityMult;
        // rhythm should be based off our agility and be converted at a rate of 1 : 0.5.
        float rhythm = intelligence * intelligenceMult;

        // Debug out our current dancing stat values (style, luck, rhythm)
        Debug.Log("Style is " + strength * strengthMult);
        Debug.Log("Luck is " + agility * agilityMult);
        Debug.Log("Rhythm is " + intelligence * intelligenceMult);

        // now let's imagine that our level has increased; and we've been granted 10 new stat points.
        // let's distribute those stats amoungst our strength and agility and intelligence.
        int additionalPoints = 10;

        //these variables must hold the values changed by the statpool so they can be distributed among the stats
        int strengthAdd = Random.Range(0, additionalPoints);
        int agilityAdd =  Random.Range(0, additionalPoints-strengthAdd);
        int intelligenceAdd = additionalPoints - strengthAdd - agilityAdd;

        // Debug out our new physical stat values
        Debug.Log("Your stats have increased!");

        Debug.Log("Strength is now " + (strength + strengthAdd));
        Debug.Log("Agility is now " + (agility + agilityAdd));
        Debug.Log("Intelligence is now " + (intelligence + intelligenceAdd));

        // let's recalculate our style, luck and rhytmn as our initial stats have changed.
        style = (strength * strengthMult);
        luck = (agility * agilityMult);
        rhythm = (intelligence * intelligenceMult);

        // Debug out our new dancing stat values
        Debug.Log("Style is now " + style);
        Debug.Log("Luck is now " + luck);
        Debug.Log("Rhythm is now " + rhythm);
    }   
}
