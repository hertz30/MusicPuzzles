// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using System;
// using System.Threading;
// using System.Threading.Tasks;
// using System.Runtime.InteropServices;

// public class PlayAnswer : MonoBehaviour
// {
//     [DllImport("__Internal")]
//     private static extern void Congrats1();
//     public List<GameObject> slotList;
//     public List<GameObject> pieceList;
//     public int delay;
//     public string answer;
//     public string altAnswer;
    
//     public async void Answer(){
//         string userAnswer = null;
//     foreach(var slot in slotList){
//         Debug.Log("slot read");
//         if(slot.GetComponent<SlotScript>().holding!=null){
//         Debug.Log("Item played");
//         int id = slot.GetComponent<SlotScript>().holdingId;
//         pieceList[id-1].GetComponent<FMODUnity.StudioEventEmitter>().Play();
//         await Task.Delay(delay);
//         userAnswer+=id;
//             }
//         }
//     if ((userAnswer == answer)||(userAnswer == altAnswer)){
//             Congrats1();
//         }
//     }
// }