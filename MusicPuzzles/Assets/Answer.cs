using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Answer : MonoBehaviour
{
    public string inputString = "";
    public int lengthOfField = 30;
     
    void OnGUI(){
        inputString = GUILayout.TextField(inputString, lengthOfField);
    }
     
    void Update() {
       
        PlayerPrefs.SetString("input text", inputString);
     
}
}
