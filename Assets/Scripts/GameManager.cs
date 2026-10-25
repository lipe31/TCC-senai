using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    
    public GameObject PipesHolder;
    public GameObject[] Pipes;

    public GameObject winUI;

    [SerializeField]
    int totalPipes = 0;
    [SerializeField]
    int correctedPipes = 0;

    private void Start()
    {
        totalPipes = PipesHolder.transform.childCount;

        Pipes = new GameObject[totalPipes];

        for (int i = 0; i < Pipes.Length; i++)
        {
            Pipes[i] = PipesHolder.transform.GetChild(i).gameObject;
        }
    }

    public void CorrectMove()
    {
        correctedPipes += 1;

        
        
        if( correctedPipes == totalPipes)
        {
            FindFirstObjectByType<VictoryPanel>()
     .MostrarVitoria();

        } 
        
    }

    public void WrongMove()
    {
        correctedPipes -= 1;
    }
}
