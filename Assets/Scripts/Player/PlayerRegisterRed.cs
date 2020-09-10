using UnityEngine;

public class PlayerRegisterRed : MonoBehaviour
{
    void Awake()
    {
        GameReferences.redPlayer = this.gameObject;
    }
}
