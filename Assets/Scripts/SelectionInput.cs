using System.Collections;
using System.Collections.Generic;
using U_Puzel;
using UnityEngine;

public class SelectionInput : MonoBehaviour
{
    #region Input/Init

    public static SelectionInput instance;
    InputManager inputs;

    private void Awake()
    {
        if (instance != null) { Debug.LogError("WTF RYLAN THERES MULTIPLE SELECTION INPUTS!! I MEAN COME ON..."); Destroy(this); }
        else { instance = this; }
        
        inputs = new InputManager();
    }
    private void OnEnable()
    {
        inputs.Enable();
    }
    private void OnDisable()
    {
        inputs.Disable();
    }

    #endregion

    public delegate void SelectionEvent(string selectID);
    public SelectionEvent selectionChangedEvent;

    private void Update()
    {
        if (inputs.playerSwitch.selectRedPlayer.triggered)
        {
            Debug.Log("Calling Player Switched Event!");
            selectionChangedEvent("red");
        }
        else if (inputs.playerSwitch.selectGreenPlayer.triggered)
        {
            Debug.Log("Calling Player Switched Event!");
            selectionChangedEvent("green");
        }
        else if (inputs.playerSwitch.selectBluePlayer.triggered)
        {
            selectionChangedEvent("blue");
        }
    }
}