using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UILoseReturnToMenu : MonoBehaviour
{
    public CartInteraction cartRef;

    void QuitGame()
    {
        cartRef.player.GetComponent<InputComponent>().OnAButtonDown -= QuitGame;
        cartRef.player.GetComponent<AnimationComponent>().animator.speed = 1f;
        cartRef.player.GetComponent<GameManagerComponent>().OnStartGameTick();
        SceneManager.LoadScene(0);
    }
    private void Awake()
    {
        cartRef.player.GetComponent<MovementComponent>().alive = false;
        cartRef.player.GetComponent<InputComponent>().OnAButtonDown += QuitGame;
    }
}
