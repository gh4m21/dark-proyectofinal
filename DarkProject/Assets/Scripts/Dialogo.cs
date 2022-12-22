using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogo : MonoBehaviour
{
    private bool isPlayerInRange;
    private bool didDialogueStart;

    private int lineIndex;

    private float typingTime = 0.05f;

    [SerializeField] private GameObject marcaDialogo;
    [SerializeField, TextArea(4,6)] private string[] lineasDialogo;
    [SerializeField] private GameObject PanelDialogo;
    [SerializeField] private TMP_Text dialogoTexto;

    // Update is called once per frame
    void Update()
    {
        if (isPlayerInRange&&Input.GetButton("Fire2"))
        {
            if (!didDialogueStart)
            {
                StartDialogo();
            }
            else if (dialogoTexto.text == lineasDialogo[lineIndex])
            {
                Nextdialogoline();
            }
            
            
        }
    }

    private void StartDialogo()
    {
        didDialogueStart = true;
        PanelDialogo.SetActive(true);
        marcaDialogo.SetActive(false);
        lineIndex = 0;
        Time.timeScale = 0;
        StartCoroutine(Showline());
    }

    private void Nextdialogoline()
    { 
        lineIndex++;
        if (lineIndex < lineasDialogo.Length)
        {
            StartCoroutine(Showline());
        }
        else {
            didDialogueStart = false;
            PanelDialogo.SetActive(false);
            marcaDialogo.SetActive(true);
            Time.timeScale = 1;
        }
    }

    private IEnumerator Showline() 
    {
        dialogoTexto.text = string.Empty;

        foreach (char ch in lineasDialogo[lineIndex])
        {
            dialogoTexto.text += ch;
            yield return new WaitForSecondsRealtime(typingTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Jugador"))
        isPlayerInRange = true;
        marcaDialogo.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Jugador"))
        isPlayerInRange = false;
        marcaDialogo.SetActive(false);
    }
}
