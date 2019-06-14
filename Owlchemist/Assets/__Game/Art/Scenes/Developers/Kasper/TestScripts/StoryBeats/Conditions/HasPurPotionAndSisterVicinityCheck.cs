using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "StoryConditions/CanPurifySister")]
public class HasPurPotionAndSisterVicinityCheck : BaseStoryProgressionCondition
{
    public float distance = 3f;
    public BaseResource purificationPotion;

    public override bool ConditionMet(PlayerFilter player, StoryBeatComponent currentBeat)
    {
        bool hasPotion = false;
        for (int i = 0; i < player.inventoryComponent.InventoryBag.Count; i++)
        {
            if (player.inventoryComponent.InventoryBag[i].itemType.baseCollectible == purificationPotion)
            {
                Debug.Log(player.inventoryComponent.InventoryBag[i].itemType.baseCollectible);
                hasPotion = true;
            } 
        }    

        float dst = Vector3.Distance(
            player.conditionsComponent.sisterCorpse.transform.position,
            player.go.transform.position
            );

        bool closeToSister = dst < distance;

        return hasPotion && closeToSister;
    }
}
