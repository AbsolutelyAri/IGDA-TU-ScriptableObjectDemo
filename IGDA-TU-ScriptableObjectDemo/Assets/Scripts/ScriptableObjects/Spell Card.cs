using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewCard", menuName = "Cards/Spell Card", order = 3)]
public class SpellCard : Card
{
    public int numTargets = 1;
    public int damage = 1;
    public string effect = "blows up the enemy";
}
