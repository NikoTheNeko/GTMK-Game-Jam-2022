using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayerScript : MonoBehaviour{

    #region Public Variables
    
    [Header("Game Objects")]
    [Tooltip("The Dice that we'll get the value from")]
    public DiceScript Dice;

    [Tooltip("The Game Manager to controlt he game")]
    public GameManagerScript GameManagerObject;

    [Tooltip("The thing that contains everyting")]
    public GameObject ParentObject;




    #endregion

    #region Private Variables
    #endregion

    // Start is called before the first frame update
    void Start(){
        GameManagerObject = GameObject.Find("Game Manager").GetComponent<GameManagerScript>();
    }

    // Update is called once per frame
    void Update(){
        
    }

    public void AdvancePlayer(){
        GameManagerObject.MovePiecePosition(Dice.GetDiceValue());
        Destroy(ParentObject);
    }
}
