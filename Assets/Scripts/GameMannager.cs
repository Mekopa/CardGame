using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class GameMannager : MonoBehaviour
{

    public PlayerManager PlayerManager;
    public CardManager CardManager;

    // Start is called before the first frame update
    void Start()
    {
        CardManager.Shuffle();
        PlayerManager.GiveCards(7);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}

public static class ListExtensions
{
    public static void Shuffle<T>(this List<T> list)
    {
        int n = list.Count;
        for (int i = n - 1; i > 0; i--)
        {
            int j = Random.Range(0, i + 1);
            (list[i], list[j]) = (list[j], list[i]);
        }
    }
}

public static class StackExtensions
{
    public static void Shuffle<T>(this Stack<T> stack)
    {
        List<T> list = new List<T>(stack);
        list.Shuffle();
        stack.Clear();
        foreach (var item in list)
        {
            stack.Push(item);
        }
    }
}

