using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThreeToOneBehavior : MonoBehaviour{

    #region Public Variables

    public DiceScript Dice1;
    public DiceScript Dice2;
    public DiceScript Dice3;

    #endregion

    #region Private Variables
    #endregion

    // Start is called before the first frame update
    void Start(){
        Dice1.RollDice();
        Dice2.RollDice();
        Dice3.RollDice();
    }

    // Update is called once per frame
    void Update(){
      
    }
}
