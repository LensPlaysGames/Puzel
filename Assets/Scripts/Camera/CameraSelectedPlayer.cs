using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSelectedPlayer : MonoBehaviour
{
    public PlayerManager playerManager;

    void Start()
    {
        playerManager = GameReferences.playerManager;

        playerManager.updateSelectedPlayer += UpdateVirtualCam;
    }

    void UpdateVirtualCam(string playerColor)
    {
        GameReferences.vCamRed.SetActive(false);
        GameReferences.vCamGreen.SetActive(false);
        GameReferences.vCamBlue.SetActive(false);

        if (playerColor == "red")
        {
            GameReferences.vCamRed.SetActive(true);
        }
        if (playerColor == "green")
        {
            GameReferences.vCamGreen.SetActive(true);
        }
        if (playerColor == "blue")
        {
            GameReferences.vCamBlue.SetActive(true);
        }
    }
}
