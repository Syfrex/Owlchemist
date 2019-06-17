using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Playables;

public class StoryEndGame : MonoBehaviour
{

    private PlayableDirector timeline;
    private GameObject playerRef;

    //[SerializeField] PlayerEventComponent eventComponent;
    // Start is called before the first frame update
    void Start()
    {
        playerRef = GameObject.FindGameObjectWithTag("Player");
        timeline = GetComponent<PlayableDirector>();
        playerRef.GetComponent<PlayerEventComponent>().StartEnd += EndingCutScene;
    }

    private void Awake()
    {
    }


    // Update is called once per frame
    void Update()
    {
        
    }
    void EndingCutScene ()
    {
        playerRef.GetComponent<NavMeshAgent>().enabled = false;
        timeline.Play();
    }
}
