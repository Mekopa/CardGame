using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    public List<Card> ListCard;
    public GameObject cardCover;


    public Stack<Card> Pool;

    public void Update()
    {
        if (Pool.Count == 0)
            Object.Destroy(cardCover);
    }
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





