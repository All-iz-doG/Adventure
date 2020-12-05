using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;     
    private int _score;
    private string _currentDoorId;
    public Color colorActual = Color.white;
    public bool espada = false;
    public bool puente = false;


    private void Awake()     
    {         
        if(instance == null)          
        {             
            instance = this;             
            DontDestroyOnLoad(this.gameObject);         
        }         
        else         
        {             
            Destroy(this);         
        }     
    }

    void Start()     
    {         
        _score = 0;     
    }     
    
    public void ChangeScenes(string SceneName)     
    {         
        SceneManager.LoadScene(SceneName);     
    }     
    
    public int GetScore()     
    {         
        return _score;     
    }     
    
    public void AddScore(int points)     
    {         
        _score += points;     
    }     
    
    public void ResetScore()     
    {         
        _score = 0;     
    } 

    public void SetDoor(string doorId) 
    {         
        _currentDoorId = doorId;     
    }
             
    public string GetDoor( ) 
    {    
        return _currentDoorId;     
    }

    public void SetColor(Color nuevoColor)
    {
        colorActual = nuevoColor;
    }

    public Color GetColor()
    {
        return colorActual;
    }

    public bool GetEspada()
    {
        return espada;
    }

    public bool GetPuente()
    {
        return puente;
    }

    public void SetEspada()
    {
        espada = true;
    }

    public void SetPuente()
    {
        puente = true;
    }
}