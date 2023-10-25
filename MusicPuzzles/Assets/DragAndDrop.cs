using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragAndDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    private RectTransform rectTrans;
    public Canvas myCanvas;
    private CanvasGroup canvasGroup;
    public int id;
    public string keyId;
    void Start(){
        rectTrans = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }
    public string getKeyID(){
        return keyId;
    }
    public void OnBeginDrag(PointerEventData eventData){
        Debug.Log("BeginDrag");
        canvasGroup.blocksRaycasts = false;
    }
    public void OnEndDrag(PointerEventData eventData){
        Debug.Log("EndDrag");
        canvasGroup.blocksRaycasts = true;
    }
    public void OnDrag(PointerEventData eventData){
        rectTrans.anchoredPosition+=eventData.delta/myCanvas.scaleFactor;
    }
    public void OnPointerDown(PointerEventData eventData){
        Debug.Log("Click");
    }
}
