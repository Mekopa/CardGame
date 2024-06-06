using System.Collections.Generic;
using UnityEngine;

public class MyPlayer : MonoBehaviour
{
    public List<Card> myCards;
    public float cardSpacing = 2.0f; // Adjust this value as needed

    public void TakeCard(Card card)
    {
        myCards.Add(card);
        card.transform.parent = transform;
       PositionCards();
    }
    public void RemoveCard(Card card)
    {
        myCards.Remove(card);
    }

    private void PositionCards()
    {
        for (int i = 0; i < myCards.Count; i++)
        {
            Vector3 cardPosition = new Vector3(i * cardSpacing, 0, 0);
            myCards[i].transform.localPosition = cardPosition;
            Debug.Log($"Card {myCards[i].name} positioned at {cardPosition} locally within {name}");
        }
    }
}

