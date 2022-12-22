using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class ChangeView : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera _virtualCamera;
    

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Jugador"))
        {
            
            _virtualCamera.Priority = 0;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        _virtualCamera.Priority = 20;
    }
}
