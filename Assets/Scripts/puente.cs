using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puente : MonoBehaviour
{
    public GameObject puentee;
    bool arriba = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.GetPuente() == true && arriba == false)
        {
            Debug.Log("Hola");
            arriba = true;
            puentee.transform.Translate(Vector3.up * 3);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // Consultamos si el objeto que interseca tiene la etiqueta del jugador.
        if (other.CompareTag("Player"))
        {
            GameManager.instance.SetPuente();
        }
    }
}
