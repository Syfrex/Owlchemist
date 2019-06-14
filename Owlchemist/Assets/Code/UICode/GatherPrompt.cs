using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GatherPrompt : MonoBehaviour
{
    public Text gatherTXT;
    public Image buttonIMG;
    public Image imgBG;

    private void Awake()
    {
        gameObject.SetActive(false);
    }
    public void ProgressFill(float fillValue)
    {
        imgBG.fillAmount = fillValue; // current / max
    }
}
