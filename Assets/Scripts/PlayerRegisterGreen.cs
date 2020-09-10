using UnityEngine;

public class PlayerRegisterGreen : MonoBehaviour
{
    void Awake()
    {
        GameReferences.greenPlayer = this.gameObject;
    }
}
