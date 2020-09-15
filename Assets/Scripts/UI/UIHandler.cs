using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace U_Puzel
{
    public class UIHandler : MonoBehaviour
    {
        public static UIHandler instance;

        private void Awake()
        {
            if (instance != null) { Debug.LogError("Multiple UIHANDLER BITCH CUNT FACES Found in Scene!!"); Destroy(this); }
            else { instance = this; }

            SetAvailablePlayersUI("red");

            // Subscribe to Selection Input Event
            StartCoroutine(WaitToRegister(.25f));
        }

        public GameObject AvailablePlayersUI;
        public List<GameObject> players;
        private void Start()
        {
            AvailablePlayersUI = transform.Find("--AvailablePlayers--").gameObject;
        }

        public void SetAvailablePlayersUI(string selectID)
        {
            for (int p = 0; p < players.Count; p++) { players[p].GetComponent<Image>().color = new Color(.72f, .72f, .72f); }
            players.Find(x => x.name == selectID).GetComponent<Image>().color = Color.white;
        }

        private IEnumerator WaitToRegister(float s)
        {
            yield return new WaitForSeconds(s);

            if (SelectionInput.instance != null)
            {
                SelectionInput.instance.selectionChangedEvent += SetAvailablePlayersUI;
            }
            else { StartCoroutine(WaitToRegister(.25f)); }
        }
    }
}