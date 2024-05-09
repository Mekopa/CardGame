using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public CardManager CardManager;
    public List<MyPlayer> players;

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
