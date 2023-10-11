using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CreatureCardPrefab : MonoBehaviour
{
    public TextMeshProUGUI cardNameText;
    public TextMeshProUGUI cardDescriptionText;
    public TextMeshProUGUI cardManaText;
    public TextMeshProUGUI cardAttackText;
    public TextMeshProUGUI cardHealthText;
    public Image cardSprite;

    private CreatureCard creatureCard;

    public void SetCard(CreatureCard cc)
    {
        creatureCard = cc;
        cardSprite.sprite = cc.cardSprite;
        cardNameText.text = cc.cardName;
        cardDescriptionText.text = cc.cardDescription;
        cardManaText.text = cc.cost.ToString();
        cardAttackText.text = cc.attack.ToString();
        cardHealthText.text = cc.health.ToString();
    }
}
