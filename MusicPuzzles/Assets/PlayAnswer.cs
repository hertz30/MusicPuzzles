using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using UnityEngine.Events;

public class PlayAnswer : MonoBehaviour
{
    [SerializeField] private UnityEvent congrats;
    [DllImport("__Internal")]
    private static extern void Congrats1();
    [DllImport("__Internal")]
    private static extern void Congrats2();
    [DllImport("__Internal")]
    private static extern void Congrats3();
    [DllImport("__Internal")]
    private static extern void CongratsTutorial();

    public List<GameObject> slotList;
    public List<GameObject> pieceList;
    public float delay;
    public string answer;
    public string altAnswer;
    
    public static PlayAnswer Instance;
    void Awake(){
        Instance = this;
    }
    
    public static void Answer(MonoBehaviour instance)
{
    Debug.Log("PlayCheck started");
    PlayAnswer.Instance.StartCoroutine(PlayAnswer.Instance.PlayCheck());
}

    IEnumerator PlayCheck(){
        string userAnswer = null;
    foreach(var slot in PlayAnswer.Instance.slotList){
        Debug.Log("slot read");
        if(slot.GetComponent<SlotScript>().holding!=null){
        Debug.Log("Item played");
        int id = slot.GetComponent<SlotScript>().holdingId;
        PlayAnswer.Instance.pieceList[id-1].GetComponent<FMODUnity.StudioEventEmitter>().Play();
        yield return new WaitForSeconds(PlayAnswer.Instance.delay);
        userAnswer+=id;
            }
        }
    if ((userAnswer == PlayAnswer.Instance.answer)||(userAnswer == PlayAnswer.Instance.altAnswer)){
            congrats.Invoke();
        }
    }

    public void congrats1(){
        Congrats1();
    }
    public void congrats2(){
        Congrats2();
    }
    public void congrats3(){
        Congrats3();
    }
    public void congratsTutorial(){
        CongratsTutorial();
    }
}