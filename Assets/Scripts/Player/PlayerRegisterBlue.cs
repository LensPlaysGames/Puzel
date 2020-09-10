using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRegisterBlue : MonoBehaviour
{
    void Awake()
    {
        GameReferences.bluePlayer = this.gameObject;
    }
}
