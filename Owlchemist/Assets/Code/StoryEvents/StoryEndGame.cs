using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryEndGame : MonoBehaviour
{

    [SerializeField] PlayerEventComponent eventComponent;
    // Start is called before the first frame update
    void Start()
    {
        
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

    }
}
