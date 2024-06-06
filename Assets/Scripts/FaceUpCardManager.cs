using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceUpCardManager : MonoBehaviour
{
    public CardManager CardManager;
    public List<MyFaceUpCards> FaceUpCards;


    public void GetClosedCards()
    {
        foreach (var FaceUpCards in FaceUpCards)
        {
            for (int i = 0; i < 3; i++)
            {
                FaceUpCards.TakeCard(CardManager.Pool.Pop());

            }
        }
    }
}
