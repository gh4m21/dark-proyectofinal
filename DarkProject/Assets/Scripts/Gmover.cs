using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Gmover : MonoBehaviour
{

    [SerializeField] private GameObject menuPerdida;

    public void ReiniciarGame()
    {

       
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
        PlayerManager.currentHealth=100;
        Time.timeScale=1f;
        PlayerManager.numberOfCoins=0;
    }

    public void Ir_Menu()
    {
        Time.timeScale = 1f;
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }


}
