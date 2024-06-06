using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FaceDownCardManager : MonoBehaviour
{

    public CardManager CardManager;
    public List<MyFaceDownCards> FaceDownCards;
    

    public void GetClosedCards()
    {
        foreach(var FaceDownCards in FaceDownCards)
        {
            for (int i = 0; i < 3; i++)
            {
                FaceDownCards.TakeCard(CardManager.Pool.Pop());
                
            }
        }
    }
}
