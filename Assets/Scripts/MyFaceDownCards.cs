using System.Collections.Generic;
using UnityEngine;

public class MyFaceDownCards : MonoBehaviour
{
    public List<Card> myCards;
    public float cardSpacing = 2.0f; // Adjust this value as needed

    public void TakeCard(Card card)
    {
        card.CardDisplay.ChangeToBack();
        myCards.Add(card);
        card.transform.parent = transform;
        PositionCards();
    }

    private void PositionCards()
    {
        for (int i = 0; i < myCards.Count; i++)
        {
            Vector3 cardPosition = new Vector3(i * cardSpacing, 0, 1);
            myCards[i].transform.localPosition = cardPosition;
            Debug.Log($"FaceDown Card {myCards[i].name} positioned at {cardPosition} locally within {name}");
        }
    }
}

