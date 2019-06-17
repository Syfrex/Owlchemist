using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UILoseReturnToMenu : MonoBehaviour
{
    private PlayerFilter player;
    public void SubscribeToButtonEvents(PlayerFilter player)
    {
        this.player = player;
        player.movementComponent.alive = false;
        player.inputComponent.OnAButtonDown += QuitGame;
    }
    void QuitGame()
    {
        player.inputComponent.OnAButtonDown -= QuitGame;
        player.animationComponent.animator.speed = 1f;
        player.gameManagerComponent.OnStartGameTick();
        SceneManager.LoadScene(0);
    }
}
