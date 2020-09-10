using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRegisterBlue : MonoBehaviour
{
    void Awake()
    {
        GameReferences.vCamBlue = this.gameObject;
        gameObject.SetActive(false);
    }
}
