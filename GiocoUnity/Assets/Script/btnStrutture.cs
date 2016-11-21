using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;
using System;

public class btnStrutture : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {
    public RectTransform container;
    public bool isOpen;

    public void OnPointerEnter(PointerEventData eventData)
    {
        isOpen = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isOpen = false;
    }

    // Use this for initialization
    void Start () {
        
        container = transform.FindChild("contenitore").GetComponent<RectTransform>();
        isOpen = false;
	}
	
	// Update is called once per frame
	void Update () {
       // Vector3 scale = container.localScale;
      //  scale.y = Mathf.Lerp(scale.y,isOpen ? 1 : 0, Time.deltaTime * 12);
       // container.localScale = scale;
        if (isOpen)
        {
            Vector3 scale = container.localScale;
            scale.y = Mathf.Lerp(scale.y, 1, Time.deltaTime * 12);
            container.localScale = scale;
        }else
        {
            Vector3 scale = container.localScale;
            scale.y = Mathf.Lerp(scale.y, 0, Time.deltaTime * 12);
            container.localScale = scale;
        }
	}
}
