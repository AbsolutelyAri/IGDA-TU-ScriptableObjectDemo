using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewCard", menuName = "Cards/Generic Card", order = 1)]
public class Card : ScriptableObject
{
    public string cardName = "New Card";
    public string cardDescription = "A new card";

    public int cost = 1;

    public Sprite cardSprite;
}
