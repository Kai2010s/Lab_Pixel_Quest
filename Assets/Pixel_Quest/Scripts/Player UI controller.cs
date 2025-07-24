using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;


public class PlayerUIcontroller : MonoBehaviour
{
    public Image healthImage;
    // Start is called before the first frame update
    private void Start() { healthImage = GameObject.Find("health").GetComponent<Image>(); }

    // Update is called once per frame
    public void UpdateHealth(float currenthealth, float maxHealth) { healthImage.fillAmount = currenthealth / maxHealth; }
    
        
    
}
