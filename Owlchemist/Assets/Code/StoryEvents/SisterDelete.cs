using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SisterDelete : MonoBehaviour
{

    [SerializeField] GameObject sisterBody;
    [SerializeField] GameObject sisterGravestone;
    [SerializeField] PlayerEventComponent eventComponent;

    public CartInteraction insideCart;

    bool decaing = false;
    float dealy = 3f;
   private void Awake()
    {
        eventComponent.OnSisterCleansed += DeleteSisterBody;
    }
    public void DeleteSisterBody()
    {
        sisterBody.gameObject.SetActive(false);
        sisterGravestone.gameObject.SetActive(true);
        decaing = true;
        insideCart.interactives[insideCart.interactives.Length - 1].GetComponent<UICartCanvas>().menuButtonsList[0].menu.GetComponent<TurnInPotion>().canAppear = true;
        insideCart.player.GetComponent<GameManagerComponent>()?.OnStopGameTick();
    }
    private void Update()
    {
        if(decaing)
        {
            if (dealy <= 0)
            {
                
                decaing = false;
                insideCart.player.GetComponent<InventoryComponent>().TransferItemsFromTo(insideCart.player.GetComponent<InventoryComponent>(), insideCart.cart.GetComponent<InventoryComponent>());
                insideCart.PlayerDeath();
            }
            else
            {
                dealy -= Time.deltaTime;
            }
        }
    }
}
