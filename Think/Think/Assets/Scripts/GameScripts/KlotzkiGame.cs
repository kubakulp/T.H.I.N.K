using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KlotzkiGame : MonoBehaviour
{
    private Vector3 mOffset;
    public char[] answer;
    public int sizeAnswer;
    public GameObject[] literki;
    public Text text;
    public TextManagerScript TextManager;
    private int licznik;
    public ScaleScript scaleScript;

    private void OnMouseDown()
    {
        mOffset = gameObject.transform.position - GetMouseWorldPos();
    }

    private void OnMouseDrag()
    {
        transform.position = GetMouseWorldPos() + mOffset;
    }

    private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }
}
