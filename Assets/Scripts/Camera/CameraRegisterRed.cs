using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRegisterRed : MonoBehaviour
{
    void Awake()
    {
        GameReferences.vCamRed = this.gameObject;
        gameObject.SetActive(false);
    }
}
