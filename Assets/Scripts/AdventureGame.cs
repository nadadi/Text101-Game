using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    public Text gameTextComponent;
    public State startingState;

    private State currentState;
    private State previousState;

    // Asignación antes de carga la escena.
    private void Awake() {
        currentState = startingState;
        previousState = currentState;
    }

    // Asignación después de cargar la escena.
    private void Start() {
        gameTextComponent.text = currentState.GetRoomText(); //"Hello World! :D"; 
    }

    // Se ejecuta 1 vez por frame. 
    private void Update() {
        ManageStates();
    }

    private void ManageStates(){
        State[] nextStates = currentState.GetNextStates();

        for (int index = 0; index < nextStates.Length; index++){
            if(Input.GetKeyDown(KeyCode.Alpha1 + index)){
                previousState = currentState;
                currentState = nextStates[index];
                break;
            }
        }

        if(previousState != currentState)
            gameTextComponent.text = currentState.GetRoomText();
    }
}
