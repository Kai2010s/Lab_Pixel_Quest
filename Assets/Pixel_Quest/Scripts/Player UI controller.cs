using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class PlayerUIcontroller : MonoBehaviour
{
    public Image healthImage;
    public TextMeshProUGUI cointext;
    // Start is called before the first frame update
   
    public void UIStart() {
        healthImage = GameObject.Find("HeartImage").GetComponent<Image>();
        cointext = GameObject.Find("CoinText").GetComponent<TextMeshProUGUI>();
    }
    
    // Update is called once per frame
    public void UpdateHealth(float currenthealth, float maxHealth) { healthImage.fillAmount = currenthealth / maxHealth; }
    public void UpdateCoin(string newText)
    {
        cointext.text = newText;
    }
        
    
}
