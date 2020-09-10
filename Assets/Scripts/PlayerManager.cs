using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    #region Singleton/Init

    public static PlayerManager instance;

    void Awake()
    {
        if (instance != null)
        {
            UnityEngine.Debug.Log("Multiple PlayerManagers! Uh-Oh...");
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
            GameReferences.playerManager = instance;
        }

        inputManager = new InputManager();
    }

    #endregion

    #region Input Init

    public InputManager inputManager;

    void OnEnable()
    {
        inputManager.playerSwitch.Enable();
    }
    void OnDisable()
    {
        inputManager.playerSwitch.Disable();
    }

    #endregion

    private PlayerMovement redPlayer, greenPlayer, bluePlayer;

    void Start()
    {
        redPlayer = GameReferences.redPlayer.GetComponent<PlayerMovement>();
        greenPlayer = GameReferences.greenPlayer.GetComponent<PlayerMovement>();
        bluePlayer = GameReferences.bluePlayer.GetComponent<PlayerMovement>();

        redPlayer.enabled = true;
        greenPlayer.enabled = false;
        bluePlayer.enabled = false;
    }

    void Update()
    {
        if (inputManager.playerSwitch.selectRedPlayer.triggered)
        {
            redPlayer.enabled = true;
            greenPlayer.enabled = false;
            bluePlayer.enabled = false;
        }
        if (inputManager.playerSwitch.selectGreenPlayer.triggered)
        {
            redPlayer.enabled = false;
            greenPlayer.enabled = true;
            bluePlayer.enabled = false;   
        }
        if (inputManager.playerSwitch.selectBluePlayer.triggered)
        {
            redPlayer.enabled = false;
            greenPlayer.enabled = false;
            bluePlayer.enabled = true;
        }
    }
}
