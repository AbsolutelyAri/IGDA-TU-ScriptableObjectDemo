using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SpellCardPrefab : MonoBehaviour
{
    public TextMeshProUGUI cardNameText;
    public TextMeshProUGUI cardDescriptionText;
    public TextMeshProUGUI cardManaText;
    public Image cardSprite;

    private SpellCard spellCard;

    public void SetCard(SpellCard sp)
    {
        spellCard = sp;
        cardSprite.sprite = sp.cardSprite;
        cardNameText.text = sp.cardName;
        cardDescriptionText.text = sp.effect;
        cardManaText.text = sp.cost.ToString();
    }
}
