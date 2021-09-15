using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ClickAllButtonsInTheSameTime : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public bool buttonPressed;
    private Button button;

    private void Start()
    {
        button = GetComponent<Button>();    
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        buttonPressed = true;
        button.image.color = new Color32(0, 255, 0, 255);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        buttonPressed = false;
        button.image.color = new Color32(255, 0, 0, 255);
    }
}
