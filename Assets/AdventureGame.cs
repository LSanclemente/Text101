
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour {

  [SerializeField] Text textComponent;
  [SerializeField] State startingState;

  State state;

	// Use this for initialization
	void Start () {
    state = startingState;
    SetText();
	}
	
	// Update is called once per frame
	void Update () {
    ManageState();
	}

  private void ManageState()
  {
    var nextStates = state.GetNextStates();
    //if (Input.GetKeyDown(KeyCode.Alpha1)) {
    //  state = nextStates[0];
    //} else if (Input.GetKeyDown(KeyCode.Alpha2)) {
    //  state = nextStates[1];

    //} else if (Input.GetKeyDown(KeyCode.Alpha3)) {
    //  state = nextStates[2];
    //}
    for (int i = 0; i < nextStates.Length; i++)
    {
      if (Input.GetKeyDown(KeyCode.Alpha1 + i)) {
        state = nextStates[i];
      }
     }
    SetText();
  }

  private void SetText() {
    textComponent.text = state.GetStateStory();
  }
}
