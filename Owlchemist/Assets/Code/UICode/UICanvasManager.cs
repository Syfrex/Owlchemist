using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;

public class UICanvasManager : MonoBehaviour
{
    EventSystem m_EventSystem;

    public MenuButtonCombination[] menuButtons = new MenuButtonCombination[] { };

    // Start is called before the first frame update
    void Start()
    {
        LoadMenu(0);
    }

    // Update is called once per frame
    void Update()
    {
        if (menuButtons[0].menu.GetComponent<Animator>().enabled)
        {
            if ((menuButtons[0].menu.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).normalizedTime > 1 && !menuButtons[0].menu.GetComponent<Animator>().IsInTransition(0)) || menuButtons[0].menu.gameObject.activeSelf == false)
            {
                menuButtons[0].menu.GetComponent<Animator>().enabled = false;
            }
        }
    }

    public void LoadMenu(int whatMenu)
    {

        if (menuButtons[whatMenu].button)
        {
            if (menuButtons[whatMenu].button.GetComponent<Button>())
            {
                menuButtons[whatMenu].button.GetComponent<Button>().OnSelect(null);
                EventSystem.current.SetSelectedGameObject(null);
                EventSystem.current.SetSelectedGameObject(menuButtons[whatMenu].button);
            }
        }
        menuButtons[whatMenu].menu.SetActive(true);
    }
    public void StartGame()
    {

    }
    public void QuitGame()
    {

    }
    /*public void PauseGame()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }*/

    [System.Serializable]
    public struct MenuButtonCombination
    {
        public GameObject menu;
        public GameObject button;
    }
}
