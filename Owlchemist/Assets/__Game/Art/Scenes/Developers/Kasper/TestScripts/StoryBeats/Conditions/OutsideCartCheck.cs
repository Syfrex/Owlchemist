using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "StoryConditions/OutsideCartCheck")]
public class OutsideCartCheck : BaseStoryProgressionCondition
{
    public override bool ConditionMet(PlayerFilter player, StoryBeatComponent currentBeat)
    {
        return player.gameManagerComponent.isOutsideCart;
    }
}
