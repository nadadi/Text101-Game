using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Room", menuName = "ScriptableObjects/New State", order = 1)]
public class State : ScriptableObject
{
    [TextArea(14, 10)]
    [SerializeField] private string roomText;
    [SerializeField] private State[] nextStates;
    // [SerializeField] private string roomText;

    public string GetRoomText(){
        return this.roomText;
    }

    public State[] GetNextStates(){
        return this.nextStates;
    }
}
