using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public CardManager CardManager;
    public List<MyPlayer> players;
    public void Update()
    {
        foreach (var player in players)
        {
            if (player.myCards.Count < 4 && CardManager.Pool.Count != 0) 
                player.TakeCard(CardManager.Pool.Pop());
        }
    }
    public void GiveCards(int amount)
    {
        foreach (var player in players)
        {
            for (int i = 0; i < amount; i++)
            {
                player.TakeCard(CardManager.Pool.Pop());
            }
        }
    }
    
}
