using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEditor;


[CreateAssetMenu(fileName = "DialogueObject", menuName = "top down/DialogueObject", order = 0)]

public class DialogueObject : ScriptableObject 
{
    [SerializeField] [TextArea] private string[] dialogue;
    [SerializeField] private Response[] responses;

    public string[] Dialogue => dialogue;

    public bool HasResponses => Responses != null && Responses.Length > 0;
    
    
    public Response[] Responses => responses; 
    
}

