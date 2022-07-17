using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceText : MonoBehaviour{

    #region Public Variables
    [Header("Game Objects")]
    [Tooltip("This is the Dice it will pull values from")]
    public DiceScript Dice;
    [Tooltip("Text that will display the value")]
    public Text DiceTextObject;
    #endregion

    #region Private Variables
    #endregion

    // Update is called once per frame
    void Update(){
        DiceTextObject.text = Dice.GetDiceValue().ToString();
    }
}
