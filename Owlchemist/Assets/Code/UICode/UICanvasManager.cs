using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class UICanvasManager : MonoBehaviour
{
    EventSystem m_EventSystem;

    public MenuButtonCombination[] menuButtons = new MenuButtonCombination[] { };

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void LoadMenu(int whatMenu)
    {
        EventSystem.current.SetSelectedGameObject(menuButtons[whatMenu].button);
        menuButtons[whatMenu].menu.SetActive(true);       
    }
    public void PauseGame()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }

    [System.Serializable]
    public struct MenuButtonCombination
    {
        public GameObject menu;
        public GameObject button;
    }
}
