using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public CardManager CardManager;
    public List<MyPlayer> players;

    // the index of the player who is playing now
    private int playerindex;

    // true while the game is going on
    private bool isGameActive;
    // IMPORTANT TO TURN IT FALSE WHEN SOMEBODY LOSES

    void Start()
    {
        // starts the player with index 0
        playerindex = 0;

        // when the game starts
        isGameActive = true;

        // activates the turns loop
        StartCoroutine(this.PlayingLoop());
    }

    public void GiveCards(int amount)
    {
        foreach (var player in players)
        {
            for (int i = 0; i < amount; i++)
            {
                player.TakeCard(CardManager.Pool.Pop());
            }
        }
    }

    // this method is to change the turn each time a player plays
    IEnumerator PlayingLoop()
    {
        while (this.isGameActive)
        {
            yield return new WaitForSeconds(2f);

            MyPlayer currentTurn = this.players[this.playerindex];
            currentTurn.InitTurn();

            // if the card played is not a 10 or 8
            if (!currentTurn.InitTurn())
            {
                // changes the turn
                this.playerindex = (this.playerindex + 1) % this.players.Count;
            }
        }
    }
}
