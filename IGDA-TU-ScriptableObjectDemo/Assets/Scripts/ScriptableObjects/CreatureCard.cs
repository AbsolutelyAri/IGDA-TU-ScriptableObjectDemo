using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewCard", menuName = "Cards/Creature Card", order = 2)]
public class CreatureCard : Card
{
    public int attack;
    public int health;
}
