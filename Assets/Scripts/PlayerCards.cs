using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerCards : MonoBehaviour
{
    public List<Card> Hand;
    public List<Card> FaceUp(3);
    public List<Card> FaceDown(3);


    public void PlayerCards()
    {
    }
    public void FaceDown (List<Card> Cards){
          FaceDown.Clear(); // clean the cards there
          FaceDown.AddRange(cards); // copy the new ones
    }
    public void FaceUp (List<Card> Cards){
          FaceUp.Clear(); // clean the cards there
          FaceUp.AddRange(cards); // copy the new ones
    }
    public void Hand (List<Card> Cards){
          Hand.Clear(); // clean the cards there
          Hand.AddRange(cards); // copy the new ones
    }
    public void NewCard (Card newOne){
          Hand.Add(newOne);
    }
    public void AddNewCards (List<Card> Cards){
          Hand.AddRange(cards);
    }
    public Card RemoveCardFromHandAtIndex(int index)
    {
        Card c;
        // verify the index
        if (index >= 0 && index < Hand.Count)
        {
            c = Hand[index];
            Hand.RemoveAt(index);
        }
    }

    
}
