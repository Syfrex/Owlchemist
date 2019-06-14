using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "StoryEvents/DisplayTutorial")]
public class DisplayTutorialPromptEvent : BaseStoryEvent
{
    CanvasGroupFader cgf = null;
    CanvasGroupFader previousCfg = null;
    public override void TriggerStoryEvent(PlayerFilter playerFilter, GameObject obj)
    {
        CanvasGroupFader fader = obj.GetComponent<CanvasGroupFader>();
        cgf = fader;
        cgf.Display(false);
    }

    public override void TriggerStoryBegin(PlayerFilter playerFilter, GameObject obj)
    {
        
    }

    public override void TriggerStoryProgress(PlayerFilter playerFilter, GameObject obj)
    {
        
    }

    public override void TriggerStoryEnd(PlayerFilter playerFilter, GameObject obj)
    {
        cgf.Hide(false);
    }
}
