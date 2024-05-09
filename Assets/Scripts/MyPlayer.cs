using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPlayer : MonoBehaviour
{
    public List<Card> myCards;
    public void TakeCard(Card card)
    {
        myCards.Add(card);
        card.transform.parent = transform;
    }
}
