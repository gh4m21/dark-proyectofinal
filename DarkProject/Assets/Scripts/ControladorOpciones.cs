using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;

public class ControladorOpciones : MonoBehaviour
{
    [SerializeField] AudioMixer audioMixer;
    public int calidad;
    public TMP_Dropdown dropdown;

    private void Start()
    {
        dropdown.value = calidad;
        calidad = PlayerPrefs.GetInt("NumeroDeCalidad", 4);
        CambiarCalidad();
    }

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
    public void CambiarCalidad()
    {
        QualitySettings.SetQualityLevel(dropdown.value);
        PlayerPrefs.SetInt("NumeroDeCalidad", dropdown.value);
        calidad = dropdown.value;

    }
}
