using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRegisterGreen : MonoBehaviour
{
    void Awake()
    {
        GameReferences.vCamGreen = this.gameObject;
        gameObject.SetActive(false);
    }
}
