using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ganar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // Consultamos si el objeto que interseca tiene la etiqueta del jugador.
        if (other.CompareTag("Player"))
        {
            GameManager.instance.ChangeScenes("Felicidades");
        }
    }
}
