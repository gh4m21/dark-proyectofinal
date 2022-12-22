using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Gmover : MonoBehaviour
{
   
    // Start is called before the first frame update
    public void ReiniciarGame()
    {
        
         UnityEngine.SceneManagement.SceneManager.LoadScene("Nivel1");
PlayerManager.currentHealth=100;
Time.timeScale=1f;
PlayerManager.numberOfCoins=0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
