using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFaceDownCards : MonoBehaviour
{
    public List<Card> myCards;
    public void TakeCard(Card card)
    {
        card.CardDisplay.ChangeToBack();
        myCards.Add(card);
        card.transform.parent = transform;
    }
}
