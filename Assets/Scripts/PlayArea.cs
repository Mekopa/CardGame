// PlayArea.cs
using UnityEngine;
using System.Collections.Generic;

public class PlayArea : MonoBehaviour
{
    public RectTransform playAreaRectTransform;
    public List<Card> cardsInPlayArea = new List<Card>();

    // Singleton instance
    public static PlayArea Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddCardToPlayArea(Card card)
    {
        if (!cardsInPlayArea.Contains(card))
        {
            cardsInPlayArea.Add(card);
            card.transform.SetParent(playAreaRectTransform, false);
        }
    }
}

