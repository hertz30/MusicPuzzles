using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Runtime.InteropServices;
using TMPro;

public class inputSubmit : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void Congrats1();

    public GameObject inputField;
    public string answer;
    public string altAnswer;
    
    public void SubmitAnswer(){
        string input = GetComponent<TMP_InputField>().text;
        
        if ((input == answer)||(input == altAnswer)){
            Congrats1();

        }
    }
}
