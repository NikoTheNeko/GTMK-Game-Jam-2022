using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OneOrNothingBehavior : MonoBehaviour{

    #region Public Variables
    [Header("Button Objects")]
    [Tooltip("The roll button")]
    public Button RollButton;
    [Tooltip("The Text that will be updated in the roll button")]
    public Text RollButtonText;

    [Header("Dice")]
    [Tooltip("The Dice that is being rolled")]
    public DiceScript Dice;

    #endregion

    #region Private Variables
    #endregion

    void Start(){
        Dice.RollDice();
        RollButtonText.text = "Roll x" + Dice.GetRollsLeft();
    }

    // Update is called once per frame
    void Update(){
        ButtonManagement();
    }

    private void ButtonManagement(){
        //Relabels the button
        RollButtonText.text = "Roll x" + Dice.GetRollsLeft();

        //If there are no more rolls left, make the button inactive
        if(Dice.GetRollsLeft() == 0)
            RollButton.interactable = false;
    }

}
