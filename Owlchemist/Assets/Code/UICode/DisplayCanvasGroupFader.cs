using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayCanvasGroupFader : MonoBehaviour
{
    CanvasGroupFader canvasGroupFader;

    public void DisplayItem()
    {
        canvasGroupFader.Display(false);
    }
}
