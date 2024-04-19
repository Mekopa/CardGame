using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CardRanks
{
    Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King, Ace
}

public class Card
{
    public CardRanks Rank { get; private set; }

    public Card(CardRanks rank)
    {
        Rank = rank;
    }

    // Method to get the sprite or representation of the card
    public Sprite GetCardSprite()
    {
        // Implement this method based on how you manage card assets in Unity
        return Resources.Load<Sprite>($"Cards/{Rank}");
    }
}

