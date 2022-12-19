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
    [SerializeField] private GameObject MenuInstrucciones;
    [SerializeField] private GameObject MenuConfiguraciones;

    // Update is called once per frame
    void Update()
    {
        // si pulsa cualquier tecla aparecera el menu principal.
        if (Input.anyKeyDown)
        {
            MenuPantallaInical.SetActive(false);
            MenuPrincipal.SetActive(true);
        }
    }

    public void Opciones()
    {
        MenuPrincipal.SetActive(false);
        MenuOpciones.SetActive(true);

    }

    public void Atras()
    {
        MenuOpciones.SetActive(false);
        MenuPrincipal.SetActive(true);
    }

    public void AtrasInstrucciones()
    {
        MenuOpciones.SetActive(true);
        MenuInstrucciones.SetActive(false);
        MenuPrincipal.SetActive(false);
    }

    public void AtrasConfiguracion()
    {
        MenuOpciones.SetActive(true);
        MenuConfiguraciones.SetActive(false);
        MenuPrincipal.SetActive(false);
    }

    public void Instruccion()
    {
        MenuOpciones.SetActive(false);
        MenuInstrucciones.SetActive(true);
        MenuPrincipal.SetActive(false);


    }

    public void Configuracion()
    {
        MenuOpciones.SetActive(false);
        MenuConfiguraciones.SetActive(true);
        MenuPrincipal.SetActive(false);

    }



    public void QuitarJuego()
    {
        Application.Quit();
    }
}
