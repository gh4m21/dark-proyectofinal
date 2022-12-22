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
    public int Nivel;

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

        if (FindObjectsOfType<Enemy>().Length == 0)
        {
            //Win Level
            winLevel = true;
            timer += Time.deltaTime;
            if (timer > 5)
            {
                int nextLevel = UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex + 1;
                if (nextLevel == 4)
                    UnityEngine.SceneManagement.SceneManager.LoadScene(nextLevel);

                if (PlayerPrefs.GetInt("ReachedLevel", 1) < nextLevel)
                    PlayerPrefs.SetInt("ReachedLevel", nextLevel);

                UnityEngine.SceneManagement.SceneManager.LoadScene(nextLevel);
            }
        }

    }
}
