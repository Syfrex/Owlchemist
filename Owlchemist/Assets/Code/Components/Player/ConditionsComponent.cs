using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionsComponent : BaseComponent
{
    public Transform firstInteractable;
    public Transform sisterCorpse;
    public bool hasPurificationPotion { get; set; }

    private void Awake()
    {
        hasPurificationPotion = false;
    }
}
