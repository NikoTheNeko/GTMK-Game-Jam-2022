using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceSelectorButtonBehavior : MonoBehaviour{

    #region Public Variables

    public int CardIndex = 0;

    public DiceRollPanelManager DiceRollPanelObject;

    #endregion

    #region Private Variables
    #endregion

    public void SpawnPanel(){
        DiceRollPanelObject.SpawnDiceType(CardIndex);
    }


}
