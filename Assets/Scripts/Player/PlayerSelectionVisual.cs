using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelectionVisual : MonoBehaviour
{
    public PlayerManager playerManager;

    [SerializeField]
    private Color selected, darkened;

    void Start()
    {
        playerManager = GameReferences.playerManager;

        playerManager.updateSelectedPlayer += UpdateVisual;
    }

    void UpdateVisual(string playerColor)
    {
        GameReferences.redPlayer.GetComponent<SpriteRenderer>().color = darkened;
        GameReferences.greenPlayer.GetComponent<SpriteRenderer>().color = darkened;
        GameReferences.bluePlayer.GetComponent<SpriteRenderer>().color = darkened;

        if (playerColor == "red") 
        {
            GameReferences.redPlayer.GetComponent<SpriteRenderer>().color = selected;
        }
        if (playerColor == "green")
        {
            GameReferences.greenPlayer.GetComponent<SpriteRenderer>().color = selected;
        }
        if (playerColor == "blue")
        {
            GameReferences.bluePlayer.GetComponent<SpriteRenderer>().color = selected;
        }
    }
}
