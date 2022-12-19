using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CargarNivel : MonoBehaviour
{
    [SerializeField] private GameObject PantallaDeCarga;
    [SerializeField] private Slider sliderCarga;

    public void LoadLevel(int NumeroEscena) 
    {
        StartCoroutine(CargarAsync(NumeroEscena));
    }

    IEnumerator CargarAsync(int NumeroEscena) 
    {
        AsyncOperation Operacion = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(NumeroEscena);
        PantallaDeCarga.SetActive(true);
        while (!Operacion.isDone)
        {
            float Progreso = Mathf.Clamp01(Operacion.progress / .9f);
            sliderCarga.value = Progreso;
            yield return new WaitForSeconds(40);  
        }

    }
}
