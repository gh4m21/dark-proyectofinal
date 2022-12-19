using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class ControladorOpciones : MonoBehaviour
{
    [SerializeField] AudioMixer audioMixer;

    //Para controlar si queremos pantalla completa
    public void PantallaCompleta(bool pantallaCompleta)
    {
        Screen.fullScreen = pantallaCompleta;
    }

    //Para controlar el volumen
    public void CambiarVolumen(float volumen)
    {
        audioMixer.SetFloat("Volumen", volumen);
    }

    //Para controlar los graficos
    public void CambiarCalidad(int index)
    {
        QualitySettings.SetQualityLevel(index);
    }
}
