using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public static int numberOfCoins;
    public TextMeshProUGUI numberOfCoinsText;
    public static float currentHealth = 100;
    public Slider healthBar;
    public Slider Slider_Coins;
    public static bool gameOver;
    public static bool winLevel;

    public GameObject gameOverPanel;
public Animator animator;

    public float timer = 0;
public GameObject Reinicio;
    void Start()
    {
        
        numberOfCoins = 0;
        gameOver = winLevel = false;
    }

    void Update()
    {
        //Display the number of coins
        numberOfCoinsText.text = " " + numberOfCoins;
             Slider_Coins.value = numberOfCoins;
        //Update the slider value
        healthBar.value = currentHealth;

     
        //game over
        if(currentHealth < 0)
        {
           
Reinicio.gameObject.SetActive(true);
Time.timeScale=0f;
           animator.SetTrigger("Dead");
       
        }

        

        }
    }
