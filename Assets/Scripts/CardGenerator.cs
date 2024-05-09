using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardGenerator : MonoBehaviour
{
    public List<Sprite> Sprites;

    public Card prefeb;

    private const int CardValueMaxCut = 13;

    [ContextMenu(nameof(Generate))]
    public void Generate() { 
        for (int i = 0; i < Sprites.Count; i++)
        {
            var value = i % CardValueMaxCut;

            value++;

            var card = Instantiate(prefeb);
            card.CardData = new CardData(value);
            card.CardDisplay.front = Sprites[i];
            card.CardDisplay.UpdateCardDisplay();
            card.name = $"Card {value:00}";
        }
    
    }
}
