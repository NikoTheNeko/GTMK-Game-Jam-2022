using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HigherOrLower : MonoBehaviour{

    #region Public Variables

    [Header("Dice")]
    public DiceScript MidDice;
    public DiceScript LowDice;
    public DiceScript HighDice;

    [Header("Text")]
    public Text MidDiceText;

    #endregion

    #region Private Variables
    #endregion

    // Start is called before the first frame update
    void Start(){

    }

    // Update is called once per frame
    void Update(){
        
        MidDice.SetDiceMin(2);
        MidDice.SetDiceMax(5);
        MidDice.RollDice();

        LowDice.SetDiceMax(MidDice.GetDiceValue() - 1);
        HighDice.SetDiceMin(MidDice.GetDiceValue() + 1);

        LowDice.RollDice();
        HighDice.RollDice();

        MidDiceText.text = MidDice.GetDiceValue().ToString();
    }
}
