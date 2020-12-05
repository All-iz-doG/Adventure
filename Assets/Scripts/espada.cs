using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class espada : MonoBehaviour
{
    public GameObject sword;
    // Start is called before the first frame update
    void Start()
    {
        if (GameManager.instance.GetEspada() == true)
        {
            Destroy(sword);
        }
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
            GameManager.instance.SetEspada();
            Destroy(sword);
        }
    }
}
