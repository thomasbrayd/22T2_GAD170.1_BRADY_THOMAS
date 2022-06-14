using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class holds all the logic for our battle system, so being able to calculate the percentage chance of us winning.
/// As well as determine which of the two characters has won a fight, or if it's a draw
/// </summary>
public class BattleSystem : MonoBehaviour
{
    private void Start()
    {
        // let's start by setting our player dancing stats to random numbers
        // style should be random between 1-10
        int playerOneStyle = Random.Range(1,11);
        // luck should be random between 0-4
        int playerOneLuck = Random.Range(0, 5);
        // Rhythm should be random between 1-6
        int playerOneRhythm = Random.Range(1, 7);
        // style should be random between 1-10
        int playerTwoStyle = Random.Range(1, 11);
        // luck should be random between 0-4
        int playerTwoLuck = Random.Range(0, 5);
        // rhythm should be random between 1-6
        int playerTwoRhythm = Random.Range(1, 7);

        // let's set our player power levels, using an algorithm, the simpliest would be luck + style + rhythm
        // this algorthim should be the same for each character to keep it fair.
        float playerOnePowerLevel = playerOneStyle + playerOneLuck + playerOneRhythm;
        float playerTwoPowerLevel = playerTwoStyle + playerTwoLuck + playerTwoRhythm;

        // Debug out the two players, power levels.
        Debug.Log("Player 1's power level is " + playerOnePowerLevel);
        Debug.Log("Player 2's power level is " + playerTwoPowerLevel);

        // calculate the percentage chance of winning the fight for each character.
        // todo this you'll need to add the two powers together, then divide your characters power against this and multiply the result by 100.
        float totalPower = playerOnePowerLevel + playerTwoPowerLevel;
        float playerOneChanceToWin = (playerOnePowerLevel / totalPower) * 100;
        float playerTwoChanceToWin = (playerTwoPowerLevel / totalPower) * 100;

        // Debug out the chance of each character to win.
        Debug.Log("The chance for Player 1 to win is " + playerOneChanceToWin + "%");
        Debug.Log("The chance for Player 2 to win is " + playerTwoChanceToWin + "%");

        Debug.Log("The results are in...");

        // We probably want to compare the powers of our characters and decide who has a higher power level; I just hope they aren't over 9000.  
        // Debug out which character has won, which has lost, or if it's a draw.
        if (playerOnePowerLevel > playerTwoPowerLevel)
        {
            Debug.Log("Player 1 Wins!");
            Debug.Log("Player 2 Loses...");
        }
        else if (playerTwoPowerLevel > playerOnePowerLevel)
        {
            Debug.Log("Player 2 Wins!");
            Debug.Log("Player 1 Loses...");
        }

        if (playerOnePowerLevel == playerTwoPowerLevel)
        {
            Debug.Log("It's a tie! " + 25);
        }

        // Debug out how much experience they should gain based on the difference of their chances to win, or if it's a draw award a default amount.
        if (playerOnePowerLevel > playerTwoPowerLevel)
        {
            Debug.Log("Player 1 gains XP: " + (50 + (((playerOneChanceToWin - playerTwoChanceToWin) * 100) / 100)));
        }
        else if (playerTwoPowerLevel > playerOnePowerLevel)
        {
            Debug.Log("Player 2 gains XP: " + (50 + (((playerOneChanceToWin - playerTwoChanceToWin) * 100) / 100)));
        }
        
        if (playerOnePowerLevel == playerTwoPowerLevel)
        {
            Debug.Log("Both players gain XP: " + 25);
        }
    }
}
