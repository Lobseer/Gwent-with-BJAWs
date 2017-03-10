using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LineDrop : MonoBehaviour, IDropHandler {

    public void OnDrop(PointerEventData eventData)
    {
        DragHandler.dragedObject.transform.SetParent(transform);
    }
}
