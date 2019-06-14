using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "StoryConditions/HasSlept")]
public class HasSleptCheck : BaseStoryProgressionCondition
{
    public override bool ConditionMet(PlayerFilter player, StoryBeatComponent currentBeat)
    {
        return player.gameManagerComponent.hasGottenShutEye;
    }
}
