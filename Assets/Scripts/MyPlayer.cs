using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPlayer : MonoBehaviour
{
    public string idName;
    public List<Card> myCards;

    void Start()
    {
        this.idName = PlayerPrefs.GetString("Username");
    }

    public void TakeCard(Card card)
    {
        myCards.Add(card);
        card.transform.parent = transform;
    }

    // return false if the player plays a 10 or 8 (not changing the turn)
    public bool InitTurn()
    {
        
        return true;
        // TODO implement playing a card logic
    }    
}

