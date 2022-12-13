using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
    [SerializeField] private GameObject MenuPantallaInical;
    [SerializeField] private GameObject MenuPrincipal;
    [SerializeField] private GameObject MenuOpciones;
    // Update is called once per frame
    void Update()
    {
        // si pulsa cualquier tecla aparecera el menu principal.
        if (Input.anyKeyDown) { 
            MenuPantallaInical.SetActive(false);
            MenuPrincipal.SetActive(true);
        }
    }

    public void Opciones()
    {
        MenuPrincipal.SetActive(false);
        MenuOpciones.SetActive(true);

    }

    public void Atras() {
        MenuOpciones.SetActive(false);
        MenuPrincipal.SetActive(true);
    }

    public void Jugar() {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }

    public void QuitarJuego()
    {
        Application.Quit();
    }
}
