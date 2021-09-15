using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTime : MonoBehaviour
{
    public TextManagerScript textManagerScript;

    private void Update()
    {
        textManagerScript.answer = System.DateTime.Now.ToString("HHmm");
    }

}
