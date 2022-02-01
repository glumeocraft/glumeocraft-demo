using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Battle : MonoBehaviour
{

    public bool isSwamp;
    public BattleHelper battleHelper;




    



    public Battle()
    {
        battleHelper = new BattleHelper();
    }

    // Start is called before the first frame update
    void Start()
    {
        isSwamp = false;
        DoBattle();
          
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void DoBattle()
    {
        Debug.Log("battle");
    }
}
