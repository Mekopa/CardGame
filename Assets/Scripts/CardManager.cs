using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    public List<Card> ListCard;

    public Stack<Card> Pool;

    public Card GetCard(CardData data)
    {
        return ListCard.Find( x => x.CardData == data);
    }

    public void Shuffle()
    {
        Pool = new Stack<Card>(ListCard);
        Pool.Shuffle();
    }

}





