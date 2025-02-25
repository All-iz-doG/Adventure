﻿// Universidad Estatal a Distancia
// Introducción a Unity
// Autor: Lic. Juan Pablo Navarro Fennell

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Renderer))]

public class ColorKey : MonoBehaviour
{
    // Miembros de clase pública
    public Color colorObjeto;

    // Miembros de clase protegidos
    protected Renderer render;

    // Método que se ejecuta cuando aparece este objeto en pantalla
    void Start()
    {
        render = GetComponent<Renderer>();
    }

    // Rutina que se ejecuta cada vez que se dibuja una nueva imagen en pantalla.
    void Update()
    {
        render.material.color = colorObjeto;
    }

    // Método que se ejecuta cuando este objeto interseca otro objeto en el juego.
    private void OnTriggerEnter(Collider other)
    {
        // Consultamos si el objeto que interseca tiene la etiqueta del jugador.
        if (other.CompareTag("Player")) 
        {
            GameManager.instance.SetColor(IntercambiarColor(GameManager.instance.GetColor()));
            Destroy(this.gameObject);
        }
    }

    // Método que reasigna colores.
    private Color IntercambiarColor(Color nuevoColor)
    {
        Color temporal = colorObjeto;
	    colorObjeto = nuevoColor;
        return temporal;
    }
}
