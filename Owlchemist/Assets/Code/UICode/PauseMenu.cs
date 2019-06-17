using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public Button defaultButton;

    private PlayerFilter player;

    public void SubscribeToPause(PlayerFilter player)
    {
        this.player = player;
        player.inputComponent.OnBButtonDown += ReturnToGame;
    }

    public void ReturnToGame()
    {
        player.animationComponent.animator.speed = 1f;
        player.gameManagerComponent.OnStartGameTick();
        gameObject.SetActive(false);
    }
}
