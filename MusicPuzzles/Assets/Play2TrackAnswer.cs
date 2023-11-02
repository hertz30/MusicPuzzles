using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using UnityEngine.Events;

public class Play2TrackAnswer : MonoBehaviour
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
    public List<string> answerList;
    public List<GameObject> pieceList;
    public float delay;
    
    public static Play2TrackAnswer Instance;
    void Awake(){
        Instance = this;
    }
    
    public static void Answer(MonoBehaviour instance)
{
    Debug.Log("PlayCheck started");
    Play2TrackAnswer.Instance.StartCoroutine(Play2TrackAnswer.Instance.PlayCheck());
}

    IEnumerator PlayCheck(){
        int i = 1;
        string userAnswer = null;
    foreach(var slot in Play2TrackAnswer.Instance.slotList){
        Debug.Log("slot read");
        if(slot.GetComponent<SlotScript>().holding!=null){
        Debug.Log("Item played");
        int id = slot.GetComponent<SlotScript>().holdingId;
        GameObject currentPiece = Play2TrackAnswer.Instance.pieceList[id-1];
        currentPiece.GetComponent<FMODUnity.StudioEventEmitter>().Play();
        if(i%2==0){ 
        yield return new WaitForSeconds(Play2TrackAnswer.Instance.delay);}
        if(currentPiece.GetComponent<DragAndDrop>().getKeyID()!="0"){
            userAnswer+=currentPiece.GetComponent<DragAndDrop>().getKeyID();
        }else{
        userAnswer+=id;
        }
        i++;
            }
        }
        Debug.Log("user answer:"+userAnswer);
    foreach(var key in Play2TrackAnswer.Instance.answerList){
        Debug.Log("Comparing Answer");
        if (userAnswer == key){
            yield return new WaitForSeconds((PlayAnswer.Instance.delay));
            congrats.Invoke();
            Debug.Log("Level Completed");
        }
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