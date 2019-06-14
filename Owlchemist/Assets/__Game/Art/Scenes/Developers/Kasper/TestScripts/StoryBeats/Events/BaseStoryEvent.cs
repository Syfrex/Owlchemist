using UnityEngine;

public abstract class BaseStoryEvent : ScriptableObject
{
    public abstract void TriggerStoryEvent(PlayerFilter playerFilter, GameObject obj);

    public abstract void TriggerStoryBegin(PlayerFilter playerFilter, GameObject obj);
    public abstract void TriggerStoryProgress(PlayerFilter playerFilter, GameObject obj);
    public abstract void TriggerStoryEnd(PlayerFilter playerFilter, GameObject obj);
}
