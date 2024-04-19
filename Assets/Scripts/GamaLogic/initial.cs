using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    private List<Card> cards = new List<Card>();

    void Start()
    {
        InitializeDeck();
    }

    void InitializeDeck()
    {
        foreach (CardRanks rank in System.Enum.GetValues(typeof(CardRanks)))
        {
            for (int i = 0; i < 4; i++)  // Assuming four suits
            {
                cards.Add(new Card(rank));
            }
        }
    }

    //shuffle deck here



    // Update is called once per frame
    void Update()
    {
        // Handle user input or game logic updates
    }
}
