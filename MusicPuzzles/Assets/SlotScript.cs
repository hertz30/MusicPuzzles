using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SlotScript : MonoBehaviour, IDropHandler
{
    public int id;
    public bool isCorrect;
    public GameObject holding;
    public int holdingId;
        public void OnDrop(PointerEventData eventData){
            holding = eventData.pointerDrag;
            holdingId = holding.GetComponent<DragAndDrop>().id;
            if (holdingId==id){
                isCorrect=true;
            }else{
                isCorrect=false;
            }
        if(eventData.pointerDrag!=null){
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition=this.GetComponent<RectTransform>().anchoredPosition;
            Debug.Log("Item moved");
        }
    }
}
