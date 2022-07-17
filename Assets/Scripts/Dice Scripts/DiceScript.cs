using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceScript : MonoBehaviour{

    #region Public Variables

    [Header("Dice Values")]
    [Tooltip("The minimum value you can roll on (inclusive)")]
    public int MinDiceValue = 1;

    [Tooltip("The max value you can roll to (inclusive)")]
    public int MaxDiceValue = 6;

    [Tooltip("The max amount of times you can roll")]
    public int MaxAmountOfRolls = 1;

    #endregion

    #region Private Variables
    
    [Header("Dice Roll Value")]
    [Tooltip("THe Dice Value that is rolled")]
    [SerializeField]private int DiceValue = 1;
    
    [Tooltip("The amount of times you can roll")]
    [SerializeField]private int RollsLeft = 1;

    #endregion

    private void Start() {
        RollsLeft = MaxAmountOfRolls;
    }

    #region Dice Rolling Functions
    
    /**
        This rolls the dice from the min to max dice value
    **/
    public void RollDice(){
        if(RollsLeft > 0){
            DiceValue = Random.Range(MinDiceValue, MaxDiceValue + 1);
            RollsLeft--;
        }
    }

    #endregion

    #region Getters 

    /**
        Grabs the value of the dice
    **/
    public int GetDiceValue(){
        return DiceValue;
    }

    public int GetRollsLeft(){
        return RollsLeft;
    }

    #endregion

    #region Setters

    public void SetDiceMin(int Min){
        MinDiceValue = Min;
    }

    public void SetDiceMax(int Max){
        MaxDiceValue = Max;
    }


    #endregion


}
