using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragHandler : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{

    public static GameObject dragedObject;
    private Transform dragArea;
    private int siblingIndex;
    private Transform startParent;

    private void Start()
    {
        dragArea = GameObject.FindGameObjectWithTag("DragArea").transform;
    }

    public void testOnMouseDown()
    {
        Debug.Log("test");
        GameObject.Find("CardInfo").GetComponent<Animation>().CrossFade("Floating");
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        dragedObject = gameObject;
        startParent = gameObject.transform.parent;
        siblingIndex = transform.GetSiblingIndex();
        GetComponent<CanvasGroup>().blocksRaycasts = false;

        transform.SetParent(dragArea);
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        ResetPos();
    }

    private void ResetPos()
    {
        dragedObject = null;
        GetComponent<CanvasGroup>().blocksRaycasts = true;
        if (transform.parent == dragArea)
        {
            transform.SetParent(startParent);
            transform.SetSiblingIndex(siblingIndex);
            //transform.position = startPosition;
        }
    }
}
