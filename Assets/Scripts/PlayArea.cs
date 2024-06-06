// PlayArea.cs
using UnityEngine;
using System.Collections.Generic;

public class PlayArea : MonoBehaviour
{
    public RectTransform playAreaRectTransform;
    public List<Card> cards = new List<Card>();

    public static PlayArea instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Dragger"))
        {
            Debug.Log("Draggable object entered the play area.");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Dragger"))
        {
            Debug.Log("Draggable object exited the play area.");
        }
    }
    public void AddCard(Card card)
    {
       
        cards.Add(card);
        card.transform.SetParent(this.transform);
        card.transform.localPosition = Vector3.zero;
        if (cards.Count > 1)
        {
            Card lastCard = cards[cards.Count - 2];
            card.transform.localPosition = new Vector3(card.transform.localPosition.x , card.transform.localPosition.y, lastCard.transform.localPosition.z -1);
            card.transform.SetAsLastSibling();
        }
        Debug.Log("Card added: " + card.name);
    }
}

