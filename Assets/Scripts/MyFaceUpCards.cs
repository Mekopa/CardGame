using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using Unity.VisualScripting;
using UnityEngine;

public class MyFaceUpCards : MonoBehaviour
{
    public List<Card> myCards;
    public float cardSpacing = 2.0f; // Adjust this value as needed
    public bool filled = false;

    public void TakeCard(Card card)
    {
        if (filled)
            return;
        card.CardDisplay.UpdateCardDisplay();
        myCards.Add(card);
        card.transform.parent = transform;
        if (myCards.Count == 3)
            filled = true;
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
            Debug.Log($"FaceDown Card {myCards[i].name} positioned at {cardPosition} locally within {name}");
        }
    }
}
