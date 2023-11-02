 using UnityEngine;
using System.Collections;
using System.Collections.Generic;
 
public class ListOfChildren : MonoBehaviour
{
    public List<GameObject> ChildrenList = new List<GameObject>();
    void Start ()
    {
        foreach (Transform child in transform)
        {
            ChildrenList.Add(child.gameObject);
            
        }
    }
}