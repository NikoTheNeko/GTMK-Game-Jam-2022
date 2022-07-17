using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour{

    #region Public Variables
    [Header("Game Objects")]
    [Tooltip("The Slider that will move the game piece")]
    public Slider GamePieceSlider;

    #endregion

    #region Private Variables
    #endregion

    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        
    }

    /**
        Moves the player position by the amount given
    **/
    public void MovePiecePosition(int NewPlace){
        GamePieceSlider.value = GamePieceSlider.value + NewPlace;
    }
}
