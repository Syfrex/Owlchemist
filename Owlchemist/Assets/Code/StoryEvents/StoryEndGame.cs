using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class StoryEndGame : MonoBehaviour
{

    public PlayableDirector timeline;
    public CartInteraction insidecartRef;

    [SerializeField] PlayerEventComponent eventComponent;
    // Start is called before the first frame update
    void Start()
    {
        timeline = GetComponent<PlayableDirector>();
    }

    private void Awake()
    {
        eventComponent.StartEnd += EndingCutScene;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
    void EndingCutScene ()
    {
        insidecartRef.player.GetComponent<GameManagerComponent>()?.OnStopGameTick();
        timeline.Play();
    }
}
