using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonSelectMenu : MonoBehaviour
{
    [SerializeField] Button selected;

    private void OnEnable()
    {
        EventSystem.current.SetSelectedGameObject(selected.gameObject);
        selected.OnSelect(null);
    }
}