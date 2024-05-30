using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * player area contains played card.
 * 
when a player drag and drop card from hand, the card must be added to player hand object.

use grid layout to show the second last card played

always last played card must be shown on top

implement a button to allow players take the cards on playground anytime

Create a card stack for needed cards.

*/

public class PlayAreaManager : MonoBehaviour
{
    public Stack<Card> PlayedCards;
    // Start is called before the first frame update
    void Start()
    {
        PlayedCards = new Stack<Card>();

    }

    // adds the new played card to the stack
    public void newCardPlayed(Card c)
    {
        PlayedCards.Push(c);
    }

    // returns the last played card
    public void dragPlayedCard()
    {
         PlayedCards.Pop();
        // TODO add to MyPlayer list bt idk the hierarchi
    }

    // Update is called once per frame
    // has to make the cards visible
    void Update()
    {
        
    }
}
