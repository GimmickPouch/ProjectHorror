using System.Collections.Generic;
using UnityEngine;

public static class CardExtensions
{
    public static void Shuffle (this List<BaseCardData> deck)
    {
        for (int i = 0; i < deck.Count; i++)
        {
            var temp = deck[i];
            int randomIndex = Random.Range(i, deck.Count);
            deck[i] = deck[randomIndex];
            deck[randomIndex] = temp;
        }
    }
}
