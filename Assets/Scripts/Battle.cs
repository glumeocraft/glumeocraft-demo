using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Battle : MonoBehaviour
{

    public Terrain BattleTerrain;
    public BattleHelper battleHelper;


    public Battle()
    {
        battleHelper = new BattleHelper();
    }

    // Start is called before the first frame update
    void Start()
    {
        AskTerrain();
        DoBattle();
          
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void AskTerrain()
    {
        Console.WriteLine("Specify battle terrain: 1 = Plains, 2 = Swamp, 3 = Mountain, 4 = Castle (there are no castles yet) ");
        var input = Console.ReadLine();
        try
        {
            BattleTerrain = Terrain(input);
        }
        catch (Exception)
        {
            Console.Write("Invalid terrain type input: please write a number from 1 to 4.");
            // Probably bad idea, can cause infinite loop:
            AskTerrain();
        }
    }

    private void DoBattle()
    {
        Debug.Log("battle");
    }

    public enum Terrain
    {
        Plains = 1,
        Swamp = 2,
        Mountain = 3,
        Castle = 4        
    }
}
