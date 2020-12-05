using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Peligro : MonoBehaviour
{
    public string p;
    public GameObject enemy;
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
            if (p == "A" && GameManager.instance.GetEspada() == false)
            SceneManager.LoadScene("PerdidaEnemigo");
            else
            {
                Destroy(enemy);
            }

            if(p == "B")
            SceneManager.LoadScene("PerdidaAcido");
        }
    }
}
