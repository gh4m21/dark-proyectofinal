using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coinbar : MonoBehaviour
{
    public Image Slider_Coins;
 
  public void UpdateCoins(float fraction)
    {
       
         Slider_Coins.fillAmount = fraction;
    }

 }