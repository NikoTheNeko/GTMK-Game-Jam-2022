using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceRollPanelManager : MonoBehaviour{

    #region Public Variables

    public GameObject[] DiceTypes;

    public Transform PanelTransform;

    #endregion

    #region Private Variables
    #endregion

    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        
    }

    public void SpawnDiceType(int index){
        Object.Instantiate(DiceTypes[index], PanelTransform);
    }
}
