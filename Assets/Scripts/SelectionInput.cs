using UnityEngine;

namespace LensorRadii.U_Puzel
{
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

        public string defaultSelection = "red";
        private void Start()
        {
            selectionChangedEvent?.Invoke(defaultSelection);
        }

        private void Update()
        {
            if (inputs.playerSwitch.selectRedPlayer.triggered)
            {
                selectionChangedEvent?.Invoke("red");
            }
            else if (inputs.playerSwitch.selectGreenPlayer.triggered)
            {
                selectionChangedEvent?.Invoke("green");
            }
            else if (inputs.playerSwitch.selectBluePlayer.triggered)
            {
                selectionChangedEvent?.Invoke("blue");
            }
        }
    }
}